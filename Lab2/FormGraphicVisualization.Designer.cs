namespace Visualization
{
    partial class FormGraphicVisualization
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
            this.components = new System.ComponentModel.Container();
            this.graphicVisualizerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.graphicVisualizerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // graphicVisualizerBindingSource
            // 
            this.graphicVisualizerBindingSource.DataSource = typeof(Visualization.GraphicTwoDimImplementor);
            // 
            // FormGraphicVisualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 655);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGraphicVisualization";
            this.Text = "FormGraphicVisualization";
            this.Load += new System.EventHandler(this.FormGraphicVisualization_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormGraphicVisualization_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.graphicVisualizerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource graphicVisualizerBindingSource;
    }
}