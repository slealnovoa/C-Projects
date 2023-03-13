namespace _301093542_leal__LAB1.zip
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
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchIndex = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInt
            // 
            this.btnInt.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.Location = new System.Drawing.Point(79, 48);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(144, 68);
            this.btnInt.TabIndex = 0;
            this.btnInt.Text = "Generate Intiger Array";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.Location = new System.Drawing.Point(358, 49);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(144, 68);
            this.btnDouble.TabIndex = 1;
            this.btnDouble.Text = "Generate Double Array";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // displayBox
            // 
            this.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayBox.Location = new System.Drawing.Point(229, 116);
            this.displayBox.Multiline = true;
            this.displayBox.Name = "displayBox";
            this.displayBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayBox.Size = new System.Drawing.Size(124, 63);
            this.displayBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Index:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result:";
            // 
            // searchIndex
            // 
            this.searchIndex.Location = new System.Drawing.Point(229, 218);
            this.searchIndex.Name = "searchIndex";
            this.searchIndex.Size = new System.Drawing.Size(124, 20);
            this.searchIndex.TabIndex = 5;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(229, 254);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(124, 20);
            this.resultBox.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(377, 214);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.searchIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchIndex;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button btnSearch;
    }
}

