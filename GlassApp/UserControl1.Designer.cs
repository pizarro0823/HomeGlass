namespace GlassApp
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_AnadirCarrito = new System.Windows.Forms.PictureBox();
            this.LblNameItem = new System.Windows.Forms.Label();
            this.LblInv = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btn_DetalleProducto = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AnadirCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_DetalleProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_AnadirCarrito
            // 
            this.btn_AnadirCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AnadirCarrito.Image = ((System.Drawing.Image)(resources.GetObject("btn_AnadirCarrito.Image")));
            this.btn_AnadirCarrito.Location = new System.Drawing.Point(136, 109);
            this.btn_AnadirCarrito.Name = "btn_AnadirCarrito";
            this.btn_AnadirCarrito.Size = new System.Drawing.Size(140, 35);
            this.btn_AnadirCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_AnadirCarrito.TabIndex = 1;
            this.btn_AnadirCarrito.TabStop = false;
            // 
            // LblNameItem
            // 
            this.LblNameItem.AutoSize = true;
            this.LblNameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameItem.ForeColor = System.Drawing.Color.White;
            this.LblNameItem.Location = new System.Drawing.Point(164, 3);
            this.LblNameItem.Name = "LblNameItem";
            this.LblNameItem.Size = new System.Drawing.Size(81, 18);
            this.LblNameItem.TabIndex = 2;
            this.LblNameItem.Text = "0100AL48";
            // 
            // LblInv
            // 
            this.LblInv.AutoSize = true;
            this.LblInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInv.ForeColor = System.Drawing.Color.White;
            this.LblInv.Location = new System.Drawing.Point(133, 56);
            this.LblInv.Name = "LblInv";
            this.LblInv.Size = new System.Drawing.Size(22, 15);
            this.LblInv.TabIndex = 3;
            this.LblInv.Text = "Inv";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(163, 34);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 24);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "$15.000";
            // 
            // btn_DetalleProducto
            // 
            this.btn_DetalleProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DetalleProducto.Image = ((System.Drawing.Image)(resources.GetObject("btn_DetalleProducto.Image")));
            this.btn_DetalleProducto.Location = new System.Drawing.Point(136, 74);
            this.btn_DetalleProducto.Name = "btn_DetalleProducto";
            this.btn_DetalleProducto.Size = new System.Drawing.Size(138, 29);
            this.btn_DetalleProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_DetalleProducto.TabIndex = 5;
            this.btn_DetalleProducto.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(67)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_DetalleProducto);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.LblInv);
            this.Controls.Add(this.LblNameItem);
            this.Controls.Add(this.btn_AnadirCarrito);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(285, 151);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AnadirCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_DetalleProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_AnadirCarrito;
        private System.Windows.Forms.Label LblNameItem;
        private System.Windows.Forms.Label LblInv;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox btn_DetalleProducto;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
