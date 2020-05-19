namespace IzsekovanjeRondelic
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.labLenght = new System.Windows.Forms.Label();
            this.labWidth = new System.Windows.Forms.Label();
            this.labRdious = new System.Windows.Forms.Label();
            this.labSpace = new System.Windows.Forms.Label();
            this.lenghtTxt = new System.Windows.Forms.TextBox();
            this.widthTxt = new System.Windows.Forms.TextBox();
            this.radiousTxt = new System.Windows.Forms.TextBox();
            this.spaceTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labResult = new System.Windows.Forms.Label();
            this.resetTextBtn = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razmik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(157, 231);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(107, 34);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Izračunaj";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.buttonCalculate);
            // 
            // labLenght
            // 
            this.labLenght.AutoSize = true;
            this.labLenght.Location = new System.Drawing.Point(68, 82);
            this.labLenght.Name = "labLenght";
            this.labLenght.Size = new System.Drawing.Size(55, 17);
            this.labLenght.TabIndex = 1;
            this.labLenght.Text = "Dolžina";
            // 
            // labWidth
            // 
            this.labWidth.AutoSize = true;
            this.labWidth.Location = new System.Drawing.Point(68, 115);
            this.labWidth.Name = "labWidth";
            this.labWidth.Size = new System.Drawing.Size(44, 17);
            this.labWidth.TabIndex = 2;
            this.labWidth.Text = "Širina";
            // 
            // labRdious
            // 
            this.labRdious.AutoSize = true;
            this.labRdious.Location = new System.Drawing.Point(68, 154);
            this.labRdious.Name = "labRdious";
            this.labRdious.Size = new System.Drawing.Size(52, 17);
            this.labRdious.TabIndex = 3;
            this.labRdious.Text = "Polmer";
            // 
            // labSpace
            // 
            this.labSpace.AutoSize = true;
            this.labSpace.Location = new System.Drawing.Point(68, 191);
            this.labSpace.Name = "labSpace";
            this.labSpace.Size = new System.Drawing.Size(54, 17);
            this.labSpace.TabIndex = 4;
            this.labSpace.Text = "Razmik";
            // 
            // lenghtTxt
            // 
            this.lenghtTxt.Location = new System.Drawing.Point(147, 81);
            this.lenghtTxt.Name = "lenghtTxt";
            this.lenghtTxt.Size = new System.Drawing.Size(117, 22);
            this.lenghtTxt.TabIndex = 5;
            // 
            // widthTxt
            // 
            this.widthTxt.Location = new System.Drawing.Point(147, 115);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(117, 22);
            this.widthTxt.TabIndex = 5;
            // 
            // radiousTxt
            // 
            this.radiousTxt.Location = new System.Drawing.Point(147, 154);
            this.radiousTxt.Name = "radiousTxt";
            this.radiousTxt.Size = new System.Drawing.Size(117, 22);
            this.radiousTxt.TabIndex = 5;
            // 
            // spaceTxt
            // 
            this.spaceTxt.Location = new System.Drawing.Point(147, 191);
            this.spaceTxt.Name = "spaceTxt";
            this.spaceTxt.Size = new System.Drawing.Size(117, 22);
            this.spaceTxt.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Rezultat,
            this.dolzina,
            this.width,
            this.Polmer,
            this.Razmik});
            this.dataGridView1.Location = new System.Drawing.Point(312, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 341);
            this.dataGridView1.TabIndex = 6;
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labResult.Location = new System.Drawing.Point(106, 317);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(0, 55);
            this.labResult.TabIndex = 7;
            // 
            // resetTextBtn
            // 
            this.resetTextBtn.Location = new System.Drawing.Point(46, 231);
            this.resetTextBtn.Name = "resetTextBtn";
            this.resetTextBtn.Size = new System.Drawing.Size(95, 34);
            this.resetTextBtn.TabIndex = 8;
            this.resetTextBtn.Text = "Počisti";
            this.resetTextBtn.UseVisualStyleBackColor = true;
            this.resetTextBtn.Click += new System.EventHandler(this.resetTextBtn_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Rezultat
            // 
            this.Rezultat.DataPropertyName = "result";
            this.Rezultat.HeaderText = "Rezultat";
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Width = 70;
            // 
            // dolzina
            // 
            this.dolzina.DataPropertyName = "lenght";
            this.dolzina.HeaderText = "Dolžina";
            this.dolzina.Name = "dolzina";
            this.dolzina.Width = 70;
            // 
            // width
            // 
            this.width.DataPropertyName = "width";
            this.width.HeaderText = "Širina";
            this.width.Name = "width";
            // 
            // Polmer
            // 
            this.Polmer.DataPropertyName = "radious";
            this.Polmer.HeaderText = "Polmer";
            this.Polmer.Name = "Polmer";
            this.Polmer.Width = 70;
            // 
            // Razmik
            // 
            this.Razmik.DataPropertyName = "space";
            this.Razmik.HeaderText = "Razmik";
            this.Razmik.Name = "Razmik";
            this.Razmik.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.resetTextBtn);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.spaceTxt);
            this.Controls.Add(this.radiousTxt);
            this.Controls.Add(this.widthTxt);
            this.Controls.Add(this.lenghtTxt);
            this.Controls.Add(this.labSpace);
            this.Controls.Add(this.labRdious);
            this.Controls.Add(this.labWidth);
            this.Controls.Add(this.labLenght);
            this.Controls.Add(this.calculateBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label labLenght;
        private System.Windows.Forms.Label labWidth;
        private System.Windows.Forms.Label labRdious;
        private System.Windows.Forms.Label labSpace;
        private System.Windows.Forms.TextBox lenghtTxt;
        private System.Windows.Forms.TextBox widthTxt;
        private System.Windows.Forms.TextBox radiousTxt;
        private System.Windows.Forms.TextBox spaceTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Button resetTextBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezultat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolzina;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razmik;
    }
}

