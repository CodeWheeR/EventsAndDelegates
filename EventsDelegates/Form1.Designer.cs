namespace EventsDelegates
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this._btnStart = new System.Windows.Forms.Button();
			this._btnAddOperation = new System.Windows.Forms.Button();
			this.lblHp = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _btnStart
			// 
			this._btnStart.Location = new System.Drawing.Point(96, 90);
			this._btnStart.Name = "_btnStart";
			this._btnStart.Size = new System.Drawing.Size(231, 73);
			this._btnStart.TabIndex = 0;
			this._btnStart.Text = "button1";
			this._btnStart.UseVisualStyleBackColor = true;
			this._btnStart.Click += new System.EventHandler(this.StartWork);
			// 
			// _btnAddOperation
			// 
			this._btnAddOperation.Location = new System.Drawing.Point(397, 220);
			this._btnAddOperation.Name = "_btnAddOperation";
			this._btnAddOperation.Size = new System.Drawing.Size(231, 73);
			this._btnAddOperation.TabIndex = 1;
			this._btnAddOperation.Text = "button1";
			this._btnAddOperation.UseVisualStyleBackColor = true;
			this._btnAddOperation.Click += new System.EventHandler(this._btnAddOperation_Click);
			// 
			// lblHp
			// 
			this.lblHp.AutoSize = true;
			this.lblHp.Location = new System.Drawing.Point(423, 90);
			this.lblHp.Name = "lblHp";
			this.lblHp.Size = new System.Drawing.Size(46, 17);
			this.lblHp.TabIndex = 2;
			this.lblHp.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblHp);
			this.Controls.Add(this._btnAddOperation);
			this.Controls.Add(this._btnStart);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _btnStart;
		private System.Windows.Forms.Button _btnAddOperation;
		private System.Windows.Forms.Label lblHp;
	}
}

