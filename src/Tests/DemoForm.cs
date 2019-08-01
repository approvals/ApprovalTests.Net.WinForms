using System;
using System.Windows.Forms;

namespace ApprovalTests.Tests.WinForms
{
    public class DemoForm : Form
    {
        private Button button1;

        private CheckBox checkBox1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        private ListBox listBox1;

        private Timer timer1;

        public DemoForm()
        {
            InitializeComponent();
        }

#pragma warning disable 67

        public event EventHandler CustomEvent;

#pragma warning restore 67

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void DemoForm_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            checkBox1 = new CheckBox();
            listBox1 = new ListBox();
            timer1 = new Timer(components);
            SuspendLayout();

            //
            // button1
            //
            button1.Location = new System.Drawing.Point(13, 13);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            //
            // checkBox1
            //
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(192, 13);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(80, 17);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;

            //
            // listBox1
            //
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(13, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(259, 212);
            listBox1.TabIndex = 2;

            //
            // timer1
            //
            timer1.Tick += timer1_Tick;

            //
            // DemoForm
            //
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(284, 262);
            Controls.Add(listBox1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Name = "DemoForm";
            Text = "DemoForm";
            Load += DemoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}