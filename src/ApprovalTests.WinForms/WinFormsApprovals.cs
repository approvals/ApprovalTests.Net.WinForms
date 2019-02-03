﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApprovalTests.Events;
using ApprovalTests.Namers;
using ApprovalUtilities.Reflection;

namespace ApprovalTests.WinForms
{
    public class WinFormsApprovals
    {
        static Func<IDisposable> addAdditionalInfo = ApprovalResults.UniqueForOs;

        public static void RegisterDefaultAdditionalInfo(Func<IDisposable> a)
        {
            addAdditionalInfo = a;
        }

        public static void VerifyEventsFor(Form form)
        {
            var sb = new StringBuilder();
            sb.Append(EventApprovals.WriteEventsToString(form, ""));

            foreach (var o in GetSubEvents(form))
            {
                sb.Append(EventApprovals.WriteEventsToString(o, GetLabelForChild(form, o)));
            }

            Approvals.Verify(sb.ToString());
        }

        public static void Verify(Form form)
        {
            using (addAdditionalInfo())
            {
                Approvals.Verify(new ApprovalFormWriter(form));
            }
        }

        public static void Verify(Control control)
        {
            using (addAdditionalInfo())
            {
                Approvals.Verify(new ApprovalControlWriter(control));
            }
        }

        private static string GetLabelForChild(object parent, object child)
        {
            var field = ReflectionUtilities.GetFieldForChild(parent, child);
            return $"({parent.GetType().Name}.{field.Name})";
        }

        private static IEnumerable<object> GetSubEvents(Form form)
        {
            return form.GetInstanceFields()
                .Select(fi => fi.GetValue(form))
                .Where(o => EventApprovals.GetEventsInformationFor(o).Any());
        }
    }
}