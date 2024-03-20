using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyYamashitaHomework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.messageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageBtn
            // 
            this.messageBtn.Location = new System.Drawing.Point(43, 36);
            this.messageBtn.Name = "messageBtn";
            this.messageBtn.Size = new System.Drawing.Size(185, 114);
            this.messageBtn.TabIndex = 0;
            this.messageBtn.Text = "Click me!";
            this.messageBtn.UseVisualStyleBackColor = true;
            this.messageBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.messageBtn);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello from Sky Yamashita!");
        }
    }
}
