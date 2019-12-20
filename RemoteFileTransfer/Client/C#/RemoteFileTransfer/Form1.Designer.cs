namespace RemoteFileTransfer
{
    partial class IndexForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ExplanationControlTool = new System.Windows.Forms.ToolTip(this.components);
            this.LocalGroup = new System.Windows.Forms.GroupBox();
            this.ServerGroup = new System.Windows.Forms.GroupBox();
            this.ChooseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.IfFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.TimeLable = new System.Windows.Forms.Label();
            this.UpdateTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ExplanationControlTool
            // 
            this.ExplanationControlTool.BackColor = System.Drawing.Color.PaleGoldenrod;
            // 
            // LocalGroup
            // 
            this.LocalGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LocalGroup.Location = new System.Drawing.Point(12, 12);
            this.LocalGroup.Name = "LocalGroup";
            this.LocalGroup.Size = new System.Drawing.Size(371, 516);
            this.LocalGroup.TabIndex = 0;
            this.LocalGroup.TabStop = false;
            this.LocalGroup.Text = "本地文件";
            this.LocalGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ServerGroup
            // 
            this.ServerGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ServerGroup.Location = new System.Drawing.Point(403, 12);
            this.ServerGroup.Name = "ServerGroup";
            this.ServerGroup.Size = new System.Drawing.Size(372, 516);
            this.ServerGroup.TabIndex = 1;
            this.ServerGroup.TabStop = false;
            this.ServerGroup.Text = "远程服务器";
            // 
            // ChooseFileDialog
            // 
            this.ChooseFileDialog.FileName = "openFileDialog1";
            // 
            // TimeLable
            // 
            this.TimeLable.AutoSize = true;
            this.TimeLable.Location = new System.Drawing.Point(1, 609);
            this.TimeLable.Name = "TimeLable";
            this.TimeLable.Size = new System.Drawing.Size(35, 12);
            this.TimeLable.TabIndex = 2;
            this.TimeLable.Text = "00:00";
            // 
            // UpdateTime
            // 
            this.UpdateTime.Interval = 1000;
            this.UpdateTime.Tick += new System.EventHandler(this.UpdateTime_Tick);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 620);
            this.Controls.Add(this.TimeLable);
            this.Controls.Add(this.ServerGroup);
            this.Controls.Add(this.LocalGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IndexForm";
            this.Text = "树莓派小面板文件传输系统-Windows客户端";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ExplanationControlTool;
        private System.Windows.Forms.GroupBox LocalGroup;
        private System.Windows.Forms.GroupBox ServerGroup;
        private System.Windows.Forms.OpenFileDialog ChooseFileDialog;
        private System.Windows.Forms.FolderBrowserDialog IfFolderDialog;
        private System.Windows.Forms.Label TimeLable;
        private System.Windows.Forms.Timer UpdateTime;
    }
}

