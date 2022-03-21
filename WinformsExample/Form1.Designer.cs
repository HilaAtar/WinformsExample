
namespace WinformsExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add = new System.Windows.Forms.Button();
            this.numA = new System.Windows.Forms.TextBox();
            this.numB = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.recv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(481, 113);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 0;
            this.add.Text = "ADD  A+B";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(342, 86);
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(100, 20);
            this.numA.TabIndex = 1;
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(592, 86);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(100, 20);
            this.numB.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(469, 33);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(72, 113);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(151, 277);
            this.treeView1.TabIndex = 4;
            // 
            // recv
            // 
            this.recv.Location = new System.Drawing.Point(342, 300);
            this.recv.Name = "recv";
            this.recv.Size = new System.Drawing.Size(350, 20);
            this.recv.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recv);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox numA;
        private System.Windows.Forms.TextBox numB;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox recv;
    }
}

