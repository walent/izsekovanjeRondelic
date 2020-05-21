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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raious = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.space = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labResult = new System.Windows.Forms.Label();
            this.resetTextBtn = new System.Windows.Forms.Button();
            this.delateEntryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(160, 231);
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
            this.labLenght.Location = new System.Drawing.Point(42, 82);
            this.labLenght.Name = "labLenght";
            this.labLenght.Size = new System.Drawing.Size(55, 17);
            this.labLenght.TabIndex = 1;
            this.labLenght.Text = "Dolžina";
            // 
            // labWidth
            // 
            this.labWidth.AutoSize = true;
            this.labWidth.Location = new System.Drawing.Point(42, 115);
            this.labWidth.Name = "labWidth";
            this.labWidth.Size = new System.Drawing.Size(44, 17);
            this.labWidth.TabIndex = 2;
            this.labWidth.Text = "Širina";
            // 
            // labRdious
            // 
            this.labRdious.AutoSize = true;
            this.labRdious.Location = new System.Drawing.Point(42, 154);
            this.labRdious.Name = "labRdious";
            this.labRdious.Size = new System.Drawing.Size(52, 17);
            this.labRdious.TabIndex = 3;
            this.labRdious.Text = "Polmer";
            // 
            // labSpace
            // 
            this.labSpace.AutoSize = true;
            this.labSpace.Location = new System.Drawing.Point(42, 191);
            this.labSpace.Name = "labSpace";
            this.labSpace.Size = new System.Drawing.Size(54, 17);
            this.labSpace.TabIndex = 4;
            this.labSpace.Text = "Razmik";
            // 
            // lenghtTxt
            // 
            this.lenghtTxt.Location = new System.Drawing.Point(123, 81);
            this.lenghtTxt.Name = "lenghtTxt";
            this.lenghtTxt.Size = new System.Drawing.Size(117, 22);
            this.lenghtTxt.TabIndex = 5;
            this.lenghtTxt.Text = "250000";
            // 
            // widthTxt
            // 
            this.widthTxt.Location = new System.Drawing.Point(123, 115);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(117, 22);
            this.widthTxt.TabIndex = 5;
            this.widthTxt.Text = "150000";
            // 
            // radiousTxt
            // 
            this.radiousTxt.Location = new System.Drawing.Point(123, 154);
            this.radiousTxt.Name = "radiousTxt";
            this.radiousTxt.Size = new System.Drawing.Size(117, 22);
            this.radiousTxt.TabIndex = 5;
            this.radiousTxt.Text = "1700";
            // 
            // spaceTxt
            // 
            this.spaceTxt.Location = new System.Drawing.Point(123, 191);
            this.spaceTxt.Name = "spaceTxt";
            this.spaceTxt.Size = new System.Drawing.Size(117, 22);
            this.spaceTxt.TabIndex = 5;
            this.spaceTxt.Text = "1000";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.resultt,
            this.lenght,
            this.width,
            this.raious,
            this.space});
            this.dataGridView1.Location = new System.Drawing.Point(312, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 341);
            this.dataGridView1.TabIndex = 6;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // resultt
            // 
            this.resultt.DataPropertyName = "result";
            this.resultt.HeaderText = "Rezultat";
            this.resultt.Name = "resultt";
            this.resultt.Width = 70;
            // 
            // lenght
            // 
            this.lenght.DataPropertyName = "lenght";
            this.lenght.HeaderText = "Dolžina";
            this.lenght.Name = "lenght";
            // 
            // width
            // 
            this.width.DataPropertyName = "width";
            this.width.HeaderText = "Širina";
            this.width.Name = "width";
            // 
            // raious
            // 
            this.raious.DataPropertyName = "radious";
            this.raious.HeaderText = "Polmer";
            this.raious.Name = "raious";
            this.raious.Width = 70;
            // 
            // space
            // 
            this.space.DataPropertyName = "space";
            this.space.HeaderText = "Odmik";
            this.space.Name = "space";
            this.space.Width = 70;
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labResult.Location = new System.Drawing.Point(47, 317);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(0, 55);
            this.labResult.TabIndex = 7;
            this.labResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resetTextBtn
            // 
            this.resetTextBtn.Location = new System.Drawing.Point(45, 231);
            this.resetTextBtn.Name = "resetTextBtn";
            this.resetTextBtn.Size = new System.Drawing.Size(95, 34);
            this.resetTextBtn.TabIndex = 8;
            this.resetTextBtn.Text = "Počisti";
            this.resetTextBtn.UseVisualStyleBackColor = true;
            this.resetTextBtn.Click += new System.EventHandler(this.resetTextBtn_Click);
            // 
            // delateEntryBtn
            // 
            this.delateEntryBtn.Location = new System.Drawing.Point(820, 387);
            this.delateEntryBtn.Name = "delateEntryBtn";
            this.delateEntryBtn.Size = new System.Drawing.Size(108, 23);
            this.delateEntryBtn.TabIndex = 9;
            this.delateEntryBtn.Text = "Izbriši zapis";
            this.delateEntryBtn.UseVisualStyleBackColor = true;
            this.delateEntryBtn.Click += new System.EventHandler(this.delateEntryBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "mm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "mm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Maximalno število rondelic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delateEntryBtn);
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
            this.Text = "Izračun rondelic";
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
        private System.Windows.Forms.Button delateEntryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultt;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn raious;
        private System.Windows.Forms.DataGridViewTextBoxColumn space;
    }
}

