
namespace Task1_Plotter
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.axesPicBox = new System.Windows.Forms.PictureBox();
            this.txtBxFunction = new System.Windows.Forms.RichTextBox();
            this.addTerm = new System.Windows.Forms.Button();
            this.coefficientTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.powTxtBx = new System.Windows.Forms.TextBox();
            this.minTxtBx = new System.Windows.Forms.TextBox();
            this.maxTxtBx = new System.Windows.Forms.TextBox();
            this.minLbl = new System.Windows.Forms.Label();
            this.maxLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axesPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(904, 505);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(158, 83);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // axesPicBox
            // 
            this.axesPicBox.BackColor = System.Drawing.Color.White;
            this.axesPicBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.axesPicBox.Location = new System.Drawing.Point(0, 0);
            this.axesPicBox.Name = "axesPicBox";
            this.axesPicBox.Size = new System.Drawing.Size(1127, 483);
            this.axesPicBox.TabIndex = 1;
            this.axesPicBox.TabStop = false;
            this.axesPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // txtBxFunction
            // 
            this.txtBxFunction.Location = new System.Drawing.Point(12, 505);
            this.txtBxFunction.Name = "txtBxFunction";
            this.txtBxFunction.ReadOnly = true;
            this.txtBxFunction.Size = new System.Drawing.Size(426, 101);
            this.txtBxFunction.TabIndex = 2;
            this.txtBxFunction.Text = "";
            // 
            // addTerm
            // 
            this.addTerm.Location = new System.Drawing.Point(460, 552);
            this.addTerm.Name = "addTerm";
            this.addTerm.Size = new System.Drawing.Size(117, 57);
            this.addTerm.TabIndex = 3;
            this.addTerm.Text = "Add Term";
            this.addTerm.UseVisualStyleBackColor = true;
            this.addTerm.Click += new System.EventHandler(this.addTerm_Click);
            // 
            // coefficientTxtBx
            // 
            this.coefficientTxtBx.Location = new System.Drawing.Point(460, 505);
            this.coefficientTxtBx.Name = "coefficientTxtBx";
            this.coefficientTxtBx.Size = new System.Drawing.Size(35, 26);
            this.coefficientTxtBx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "* X";
            // 
            // powTxtBx
            // 
            this.powTxtBx.Location = new System.Drawing.Point(541, 489);
            this.powTxtBx.Name = "powTxtBx";
            this.powTxtBx.Size = new System.Drawing.Size(15, 26);
            this.powTxtBx.TabIndex = 6;
            // 
            // minTxtBx
            // 
            this.minTxtBx.Location = new System.Drawing.Point(741, 501);
            this.minTxtBx.Name = "minTxtBx";
            this.minTxtBx.Size = new System.Drawing.Size(100, 26);
            this.minTxtBx.TabIndex = 7;
            // 
            // maxTxtBx
            // 
            this.maxTxtBx.Location = new System.Drawing.Point(741, 533);
            this.maxTxtBx.Name = "maxTxtBx";
            this.maxTxtBx.Size = new System.Drawing.Size(100, 26);
            this.maxTxtBx.TabIndex = 8;
            // 
            // minLbl
            // 
            this.minLbl.AutoSize = true;
            this.minLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLbl.Location = new System.Drawing.Point(686, 500);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(55, 25);
            this.minLbl.TabIndex = 9;
            this.minLbl.Text = "Min :";
            // 
            // maxLbl
            // 
            this.maxLbl.AutoSize = true;
            this.maxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLbl.Location = new System.Drawing.Point(680, 536);
            this.maxLbl.Name = "maxLbl";
            this.maxLbl.Size = new System.Drawing.Size(61, 25);
            this.maxLbl.TabIndex = 10;
            this.maxLbl.Text = "Max :";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(583, 572);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(93, 37);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1127, 618);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.maxLbl);
            this.Controls.Add(this.minLbl);
            this.Controls.Add(this.maxTxtBx);
            this.Controls.Add(this.minTxtBx);
            this.Controls.Add(this.powTxtBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coefficientTxtBx);
            this.Controls.Add(this.addTerm);
            this.Controls.Add(this.txtBxFunction);
            this.Controls.Add(this.axesPicBox);
            this.Controls.Add(this.btnDraw);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Function Plotter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axesPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox axesPicBox;
        private System.Windows.Forms.RichTextBox txtBxFunction;
        private System.Windows.Forms.Button addTerm;
        private System.Windows.Forms.TextBox coefficientTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox powTxtBx;
        private System.Windows.Forms.TextBox minTxtBx;
        private System.Windows.Forms.TextBox maxTxtBx;
        private System.Windows.Forms.Label minLbl;
        private System.Windows.Forms.Label maxLbl;
        private System.Windows.Forms.Button clearBtn;
    }
}

