using System;
using System.Windows.Forms;

namespace HearThis.UI
{
    partial class ScriptTextHasChangedControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.PictureBox iconShiftClips;
			this._txtThen = new System.Windows.Forms.RichTextBox();
			this._masterTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this._lblNow = new System.Windows.Forms.Label();
			this._panelThen = new System.Windows.Forms.FlowLayoutPanel();
			this._lblBefore = new System.Windows.Forms.Label();
			this._lblRecordedDate = new System.Windows.Forms.Label();
			this._txtNow = new System.Windows.Forms.RichTextBox();
			this._lblProblemSummary = new System.Windows.Forms.Label();
			this._tableOptions = new System.Windows.Forms.TableLayoutPanel();
			this._btnUseExisting = new HearThis.UI.RadioButtonHelperButton();
			this._rdoUseExisting = new System.Windows.Forms.RadioButton();
			this._rdoAskLater = new System.Windows.Forms.RadioButton();
			this._btnAskLater = new HearThis.UI.RadioButtonHelperButton();
			this._rdoReRecord = new System.Windows.Forms.RadioButton();
			this._btnDelete = new HearThis.UI.RadioButtonHelperButton();
			this._flowNearbyText = new System.Windows.Forms.FlowLayoutPanel();
			this._lblShiftClips = new System.Windows.Forms.Label();
			this._btnShiftClips = new System.Windows.Forms.Button();
			this.l10NSharpExtender1 = new L10NSharp.UI.L10NSharpExtender(this.components);
			this._btnPlayClip = new System.Windows.Forms.Button();
			this._problemIcon = new System.Windows.Forms.PictureBox();
			this._audioButtonsControl = new HearThis.UI.AudioButtonsControl();
			this._nextButton = new HearThis.UI.MouseSensitiveIconButton();
			this._tableButtons = new System.Windows.Forms.TableLayoutPanel();
			this._pnlPlayClip = new System.Windows.Forms.FlowLayoutPanel();
			this._pnlProblemSummary = new System.Windows.Forms.TableLayoutPanel();
			iconShiftClips = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(iconShiftClips)).BeginInit();
			this._masterTableLayoutPanel.SuspendLayout();
			this._panelThen.SuspendLayout();
			this._tableOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._btnUseExisting)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._btnAskLater)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._btnDelete)).BeginInit();
			this._flowNearbyText.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.l10NSharpExtender1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._problemIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._nextButton)).BeginInit();
			this._tableButtons.SuspendLayout();
			this._pnlPlayClip.SuspendLayout();
			this._pnlProblemSummary.SuspendLayout();
			this.SuspendLayout();
			// 
			// iconShiftClips
			// 
			iconShiftClips.Image = global::HearThis.Properties.Resources.shift_clips24;
			this.l10NSharpExtender1.SetLocalizableToolTip(iconShiftClips, null);
			this.l10NSharpExtender1.SetLocalizationComment(iconShiftClips, null);
			this.l10NSharpExtender1.SetLocalizingId(iconShiftClips, "pictureBox1");
			iconShiftClips.Location = new System.Drawing.Point(3, 3);
			iconShiftClips.Name = "iconShiftClips";
			iconShiftClips.Size = new System.Drawing.Size(24, 20);
			iconShiftClips.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			iconShiftClips.TabIndex = 0;
			iconShiftClips.TabStop = false;
			// 
			// _txtThen
			// 
			this._txtThen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtThen.BackColor = System.Drawing.SystemColors.Window;
			this._txtThen.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._txtThen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this._txtThen.Location = new System.Drawing.Point(6, 43);
			this._txtThen.Margin = new System.Windows.Forms.Padding(6);
			this._txtThen.Name = "_txtThen";
			this._txtThen.ReadOnly = true;
			this._txtThen.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this._txtThen.Size = new System.Drawing.Size(316, 433);
			this._txtThen.TabIndex = 6;
			this._txtThen.Text = "";
			// 
			// _masterTableLayoutPanel
			// 
			this._masterTableLayoutPanel.ColumnCount = 2;
			this._masterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._masterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._masterTableLayoutPanel.Controls.Add(this._lblNow, 1, 0);
			this._masterTableLayoutPanel.Controls.Add(this._panelThen, 0, 0);
			this._masterTableLayoutPanel.Controls.Add(this._txtThen, 0, 1);
			this._masterTableLayoutPanel.Controls.Add(this._txtNow, 1, 1);
			this._masterTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._masterTableLayoutPanel.Location = new System.Drawing.Point(10, 43);
			this._masterTableLayoutPanel.Name = "_masterTableLayoutPanel";
			this._masterTableLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 14, 0, 10);
			this._masterTableLayoutPanel.RowCount = 2;
			this._masterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._masterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._masterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._masterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._masterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._masterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._masterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._masterTableLayoutPanel.Size = new System.Drawing.Size(657, 492);
			this._masterTableLayoutPanel.TabIndex = 0;
			// 
			// _lblNow
			// 
			this._lblNow.AutoSize = true;
			this._lblNow.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l10NSharpExtender1.SetLocalizableToolTip(this._lblNow, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._lblNow, null);
			this.l10NSharpExtender1.SetLocalizingId(this._lblNow, "ScriptTextHasChangedControl._lblNow");
			this._lblNow.Location = new System.Drawing.Point(331, 14);
			this._lblNow.Name = "_lblNow";
			this._lblNow.Size = new System.Drawing.Size(46, 23);
			this._lblNow.TabIndex = 4;
			this._lblNow.Text = "Now";
			// 
			// _panelThen
			// 
			this._panelThen.AutoSize = true;
			this._panelThen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._panelThen.Controls.Add(this._lblBefore);
			this._panelThen.Controls.Add(this._lblRecordedDate);
			this._panelThen.Location = new System.Drawing.Point(0, 14);
			this._panelThen.Margin = new System.Windows.Forms.Padding(0);
			this._panelThen.Name = "_panelThen";
			this._panelThen.Size = new System.Drawing.Size(115, 23);
			this._panelThen.TabIndex = 19;
			// 
			// _lblBefore
			// 
			this._lblBefore.AutoSize = true;
			this._lblBefore.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l10NSharpExtender1.SetLocalizableToolTip(this._lblBefore, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._lblBefore, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._lblBefore, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._lblBefore, "ScriptTextHasChangedControl._lblBefore");
			this._lblBefore.Location = new System.Drawing.Point(3, 0);
			this._lblBefore.Name = "_lblBefore";
			this._lblBefore.Size = new System.Drawing.Size(60, 23);
			this._lblBefore.TabIndex = 2;
			this._lblBefore.Text = "Before";
			// 
			// _lblRecordedDate
			// 
			this._lblRecordedDate.AutoSize = true;
			this._lblRecordedDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
			this.l10NSharpExtender1.SetLocalizableToolTip(this._lblRecordedDate, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._lblRecordedDate, null);
			this.l10NSharpExtender1.SetLocalizingId(this._lblRecordedDate, "ScriptTextHasChangedControl._lblRecordedDate");
			this._lblRecordedDate.Location = new System.Drawing.Point(69, 0);
			this._lblRecordedDate.Name = "_lblRecordedDate";
			this._lblRecordedDate.Size = new System.Drawing.Size(43, 23);
			this._lblRecordedDate.TabIndex = 3;
			this._lblRecordedDate.Text = "({0})";
			// 
			// _txtNow
			// 
			this._txtNow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._txtNow.BackColor = System.Drawing.SystemColors.Window;
			this._txtNow.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._txtNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this._txtNow.Location = new System.Drawing.Point(334, 43);
			this._txtNow.Margin = new System.Windows.Forms.Padding(6, 6, 3, 6);
			this._txtNow.Name = "_txtNow";
			this._txtNow.ReadOnly = true;
			this._txtNow.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this._txtNow.Size = new System.Drawing.Size(320, 433);
			this._txtNow.TabIndex = 7;
			this._txtNow.Text = "";
			// 
			// _lblProblemSummary
			// 
			this._lblProblemSummary.AutoSize = true;
			this._lblProblemSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._lblProblemSummary.Font = new System.Drawing.Font("Segoe UI", 12F);
			this._lblProblemSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(17)))));
			this._lblProblemSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._lblProblemSummary, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._lblProblemSummary, null);
			this.l10NSharpExtender1.SetLocalizingId(this._lblProblemSummary, "ScriptTextHasChangedControl._lblProblemSummary");
			this._lblProblemSummary.Location = new System.Drawing.Point(40, 6);
			this._lblProblemSummary.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this._lblProblemSummary.MaximumSize = new System.Drawing.Size(0, 400);
			this._lblProblemSummary.Name = "_lblProblemSummary";
			this._lblProblemSummary.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this._lblProblemSummary.Size = new System.Drawing.Size(310, 21);
			this._lblProblemSummary.TabIndex = 22;
			this._lblProblemSummary.Text = "The text has changed since it was recorded.";
			this._lblProblemSummary.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// _tableOptions
			// 
			this._tableOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._tableOptions.AutoSize = true;
			this._tableOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._tableOptions.ColumnCount = 2;
			this._tableOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._tableOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableOptions.Controls.Add(this._btnUseExisting, 1, 1);
			this._tableOptions.Controls.Add(this._rdoUseExisting, 0, 1);
			this._tableOptions.Controls.Add(this._rdoAskLater, 0, 0);
			this._tableOptions.Controls.Add(this._btnAskLater, 1, 0);
			this._tableOptions.Controls.Add(this._rdoReRecord, 0, 2);
			this._tableOptions.Controls.Add(this._btnDelete, 1, 2);
			this._tableOptions.Controls.Add(this._flowNearbyText, 1, 3);
			this._tableOptions.Controls.Add(this._btnShiftClips, 1, 4);
			this._tableOptions.Location = new System.Drawing.Point(331, 3);
			this._tableOptions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this._tableOptions.Name = "_tableOptions";
			this._tableOptions.RowCount = 5;
			this._tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableOptions.Size = new System.Drawing.Size(323, 198);
			this._tableOptions.TabIndex = 24;
			// 
			// _btnUseExisting
			// 
			this._btnUseExisting.AutoSize = true;
			this._btnUseExisting.FlatAppearance.BorderSize = 0;
			this._btnUseExisting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this._btnUseExisting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this._btnUseExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnUseExisting.Font = new System.Drawing.Font("Segoe UI", 12F);
			this._btnUseExisting.HighContrastMouseOverImage = global::HearThis.Properties.Resources.OK_mouseOverHC;
			this._btnUseExisting.Image = global::HearThis.Properties.Resources.OK;
			this._btnUseExisting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._btnUseExisting, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._btnUseExisting, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._btnUseExisting, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._btnUseExisting, "ScriptTextHasChangedControl._btnUseExisting");
			this._btnUseExisting.Location = new System.Drawing.Point(23, 40);
			this._btnUseExisting.MouseOverImage = global::HearThis.Properties.Resources.OK_MouseOver;
			this._btnUseExisting.Name = "_btnUseExisting";
			this._btnUseExisting.RoundedBorderColor = System.Drawing.Color.Empty;
			this._btnUseExisting.RoundedBorderThickness = 0;
			this._btnUseExisting.Size = new System.Drawing.Size(202, 31);
			this._btnUseExisting.TabIndex = 10;
			this._btnUseExisting.Text = "It\'s OK, use existing clip";
			this._btnUseExisting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnUseExisting.UseVisualStyleBackColor = true;
			// 
			// _rdoUseExisting
			// 
			this._rdoUseExisting.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._rdoUseExisting.AutoSize = true;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._rdoUseExisting, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._rdoUseExisting, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._rdoUseExisting, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._rdoUseExisting, "ScriptTextHasChangedControl._rdoUseExisting");
			this._rdoUseExisting.Location = new System.Drawing.Point(3, 49);
			this._rdoUseExisting.Name = "_rdoUseExisting";
			this._rdoUseExisting.Size = new System.Drawing.Size(14, 13);
			this._rdoUseExisting.TabIndex = 2;
			this._rdoUseExisting.UseVisualStyleBackColor = true;
			this._rdoUseExisting.CheckedChanged += new System.EventHandler(this._rdoUseExisting_CheckedChanged);
			// 
			// _rdoAskLater
			// 
			this._rdoAskLater.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._rdoAskLater.AutoSize = true;
			this._rdoAskLater.Checked = true;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._rdoAskLater, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._rdoAskLater, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._rdoAskLater, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._rdoAskLater, "ScriptTextHasChangedControl._rdoAskLater");
			this._rdoAskLater.Location = new System.Drawing.Point(3, 12);
			this._rdoAskLater.Name = "_rdoAskLater";
			this._rdoAskLater.Size = new System.Drawing.Size(14, 13);
			this._rdoAskLater.TabIndex = 0;
			this._rdoAskLater.TabStop = true;
			this._rdoAskLater.UseVisualStyleBackColor = true;
			this._rdoAskLater.CheckedChanged += new System.EventHandler(this._rdoAskLater_CheckedChanged);
			// 
			// _btnAskLater
			// 
			this._btnAskLater.AutoSize = true;
			this._btnAskLater.FlatAppearance.BorderSize = 0;
			this._btnAskLater.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this._btnAskLater.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this._btnAskLater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnAskLater.Font = new System.Drawing.Font("Segoe UI", 12F);
			this._btnAskLater.HighContrastMouseOverImage = global::HearThis.Properties.Resources.Later_MouseOverHC;
			this._btnAskLater.Image = global::HearThis.Properties.Resources.Later;
			this._btnAskLater.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._btnAskLater, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._btnAskLater, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._btnAskLater, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._btnAskLater, "ScriptTextHasChangedControl._btnAskLater");
			this._btnAskLater.Location = new System.Drawing.Point(23, 3);
			this._btnAskLater.MouseOverImage = global::HearThis.Properties.Resources.Later_MouseOver;
			this._btnAskLater.Name = "_btnAskLater";
			this._btnAskLater.RoundedBorderColor = System.Drawing.Color.Empty;
			this._btnAskLater.RoundedBorderThickness = 0;
			this._btnAskLater.Size = new System.Drawing.Size(127, 31);
			this._btnAskLater.TabIndex = 1;
			this._btnAskLater.Text = "Ask me later";
			this._btnAskLater.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnAskLater.UseVisualStyleBackColor = true;
			// 
			// _rdoReRecord
			// 
			this._rdoReRecord.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._rdoReRecord.AutoSize = true;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._rdoReRecord, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._rdoReRecord, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._rdoReRecord, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._rdoReRecord, "ScriptTextHasChangedControl._rdoAskLater");
			this._rdoReRecord.Location = new System.Drawing.Point(3, 86);
			this._rdoReRecord.Name = "_rdoReRecord";
			this._rdoReRecord.Size = new System.Drawing.Size(14, 13);
			this._rdoReRecord.TabIndex = 3;
			this._rdoReRecord.UseVisualStyleBackColor = true;
			this._rdoReRecord.CheckedChanged += new System.EventHandler(this._rdoReRecord_CheckedChanged);
			// 
			// _btnDelete
			// 
			this._btnDelete.AutoSize = true;
			this._btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._btnDelete.BackColor = System.Drawing.Color.Transparent;
			this._btnDelete.FlatAppearance.BorderSize = 0;
			this._btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this._btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
			this._btnDelete.ForeColor = System.Drawing.Color.DarkGray;
			this._btnDelete.HighContrastMouseOverImage = global::HearThis.Properties.Resources.Delete_MouseOverHC;
			this._btnDelete.Image = global::HearThis.Properties.Resources.Delete;
			this._btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._btnDelete, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._btnDelete, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._btnDelete, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._btnDelete, "ScriptTextHasChangedControl._btnDelete");
			this._btnDelete.Location = new System.Drawing.Point(23, 77);
			this._btnDelete.MouseOverImage = global::HearThis.Properties.Resources.Delete_MouseOver;
			this._btnDelete.Name = "_btnDelete";
			this._btnDelete.RoundedBorderColor = System.Drawing.Color.Empty;
			this._btnDelete.RoundedBorderThickness = 0;
			this._btnDelete.Size = new System.Drawing.Size(206, 31);
			this._btnDelete.TabIndex = 9;
			this._btnDelete.Text = "Need to re-record block";
			this._btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnDelete.UseVisualStyleBackColor = false;
			this._btnDelete.Visible = false;
			// 
			// _flowNearbyText
			// 
			this._flowNearbyText.AutoSize = true;
			this._flowNearbyText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._flowNearbyText.Controls.Add(iconShiftClips);
			this._flowNearbyText.Controls.Add(this._lblShiftClips);
			this._flowNearbyText.Location = new System.Drawing.Point(23, 114);
			this._flowNearbyText.Name = "_flowNearbyText";
			this._flowNearbyText.Size = new System.Drawing.Size(249, 26);
			this._flowNearbyText.TabIndex = 11;
			// 
			// _lblShiftClips
			// 
			this._lblShiftClips.AutoSize = true;
			this._lblShiftClips.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.l10NSharpExtender1.SetLocalizableToolTip(this._lblShiftClips, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._lblShiftClips, null);
			this.l10NSharpExtender1.SetLocalizingId(this._lblShiftClips, "ScriptTextHasChangedControl._lblShiftClips");
			this._lblShiftClips.Location = new System.Drawing.Point(33, 0);
			this._lblShiftClips.Name = "_lblShiftClips";
			this._lblShiftClips.Size = new System.Drawing.Size(213, 21);
			this._lblShiftClips.TabIndex = 1;
			this._lblShiftClips.Text = "This clip is for a nearby block.";
			// 
			// _btnShiftClips
			// 
			this._btnShiftClips.AutoSize = true;
			this._btnShiftClips.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._btnShiftClips.FlatAppearance.BorderSize = 0;
			this._btnShiftClips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnShiftClips.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.l10NSharpExtender1.SetLocalizableToolTip(this._btnShiftClips, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._btnShiftClips, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._btnShiftClips, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._btnShiftClips, "ScriptTextHasChangedControl._btnShiftClips");
			this._btnShiftClips.Location = new System.Drawing.Point(50, 146);
			this._btnShiftClips.Margin = new System.Windows.Forms.Padding(30, 3, 3, 0);
			this._btnShiftClips.Name = "_btnShiftClips";
			this._btnShiftClips.Size = new System.Drawing.Size(131, 31);
			this._btnShiftClips.TabIndex = 12;
			this._btnShiftClips.Text = "Shift Clips Tool...";
			this._btnShiftClips.UseVisualStyleBackColor = true;
			this._btnShiftClips.Click += new System.EventHandler(this._btnShiftClips_Click);
			this._btnShiftClips.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintRoundedBorder);
			this._btnShiftClips.MouseEnter += new System.EventHandler(this._btnShiftClips_MouseEnter);
			this._btnShiftClips.MouseLeave += new System.EventHandler(this._btnShiftClips_MouseLeave);
			// 
			// l10NSharpExtender1
			// 
			this.l10NSharpExtender1.LocalizationManagerId = "HearThis";
			this.l10NSharpExtender1.PrefixForNewItems = "";
			// 
			// _btnPlayClip
			// 
			this._btnPlayClip.AutoSize = true;
			this._btnPlayClip.FlatAppearance.BorderSize = 0;
			this._btnPlayClip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnPlayClip.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.l10NSharpExtender1.SetLocalizableToolTip(this._btnPlayClip, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._btnPlayClip, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._btnPlayClip, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._btnPlayClip, "ScriptTextHasChangedControl._btnPlayClip");
			this._btnPlayClip.Location = new System.Drawing.Point(53, 3);
			this._btnPlayClip.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this._btnPlayClip.Name = "_btnPlayClip";
			this._btnPlayClip.Size = new System.Drawing.Size(139, 33);
			this._btnPlayClip.TabIndex = 0;
			this._btnPlayClip.Text = "Play Existing Clip";
			this._btnPlayClip.UseVisualStyleBackColor = true;
			this._btnPlayClip.Click += new System.EventHandler(this._btnPlayClip_Click);
			this._btnPlayClip.MouseEnter += new System.EventHandler(this._btnPlayClip_MouseEnter);
			this._btnPlayClip.MouseLeave += new System.EventHandler(this._btnPlayClip_MouseLeave);
			// 
			// _problemIcon
			// 
			this._problemIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._problemIcon.Image = global::HearThis.Properties.Resources.AlertCircle;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._problemIcon, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._problemIcon, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._problemIcon, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._problemIcon, "ScriptTextHasChangedControl._problemIcon");
			this._problemIcon.Location = new System.Drawing.Point(6, 6);
			this._problemIcon.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
			this._problemIcon.Name = "_problemIcon";
			this._problemIcon.Size = new System.Drawing.Size(21, 21);
			this._problemIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._problemIcon.TabIndex = 0;
			this._problemIcon.TabStop = false;
			// 
			// _audioButtonsControl
			// 
			this._audioButtonsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._audioButtonsControl.AutoSize = true;
			this._audioButtonsControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._audioButtonsControl.BackColor = System.Drawing.Color.Transparent;
			this._audioButtonsControl.ButtonHighlightMode = HearThis.UI.AudioButtonsControl.ButtonHighlightModes.Play;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._audioButtonsControl, "Play existing clip");
			this.l10NSharpExtender1.SetLocalizationComment(this._audioButtonsControl, null);
			this.l10NSharpExtender1.SetLocalizingId(this._audioButtonsControl, "AudioButtonsControl");
			this._audioButtonsControl.Location = new System.Drawing.Point(0, 0);
			this._audioButtonsControl.Margin = new System.Windows.Forms.Padding(0);
			this._audioButtonsControl.MinimumSize = new System.Drawing.Size(0, 42);
			this._audioButtonsControl.Name = "_audioButtonsControl";
			this._audioButtonsControl.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this._audioButtonsControl.RecordingDevice = null;
			this._audioButtonsControl.ShowNextButton = false;
			this._audioButtonsControl.ShowPlayButton = true;
			this._audioButtonsControl.ShowRecordButton = false;
			this._audioButtonsControl.Size = new System.Drawing.Size(43, 42);
			this._audioButtonsControl.TabIndex = 8;
			// 
			// _nextButton
			// 
			this._nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._nextButton.AutoSize = true;
			this._nextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._nextButton.FlatAppearance.BorderSize = 0;
			this._nextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this._nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this._nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._nextButton.Font = new System.Drawing.Font("Segoe UI", 14F);
			this._nextButton.HighContrastMouseOverImage = global::HearThis.Properties.Resources.NextArrow_MouseOverHC;
			this._nextButton.Image = global::HearThis.Properties.Resources.NextArrow;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._nextButton, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._nextButton, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._nextButton, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._nextButton, "ScriptTextHasChangedControl._nextButton");
			this._nextButton.Location = new System.Drawing.Point(543, 201);
			this._nextButton.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
			this._nextButton.MinimumSize = new System.Drawing.Size(106, 0);
			this._nextButton.MouseOverImage = global::HearThis.Properties.Resources.NextArrow_MouseOver;
			this._nextButton.Name = "_nextButton";
			this._nextButton.Padding = new System.Windows.Forms.Padding(10, 1, 6, 1);
			this._nextButton.RoundedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(17)))));
			this._nextButton.RoundedBorderThickness = 1;
			this._nextButton.Size = new System.Drawing.Size(106, 37);
			this._nextButton.TabIndex = 21;
			this._nextButton.Text = "Next";
			this._nextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this._nextButton.UseVisualStyleBackColor = false;
			this._nextButton.Click += new System.EventHandler(this.OnNextButton);
			// 
			// _tableButtons
			// 
			this._tableButtons.AutoSize = true;
			this._tableButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._tableButtons.ColumnCount = 2;
			this._tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tableButtons.Controls.Add(this._pnlPlayClip, 0, 0);
			this._tableButtons.Controls.Add(this._tableOptions, 1, 0);
			this._tableButtons.Controls.Add(this._nextButton, 1, 1);
			this._tableButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._tableButtons.Location = new System.Drawing.Point(10, 297);
			this._tableButtons.Margin = new System.Windows.Forms.Padding(0);
			this._tableButtons.Name = "_tableButtons";
			this._tableButtons.RowCount = 2;
			this._tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableButtons.Size = new System.Drawing.Size(657, 238);
			this._tableButtons.TabIndex = 23;
			// 
			// _pnlPlayClip
			// 
			this._pnlPlayClip.AutoSize = true;
			this._pnlPlayClip.Controls.Add(this._audioButtonsControl);
			this._pnlPlayClip.Controls.Add(this._btnPlayClip);
			this._pnlPlayClip.Location = new System.Drawing.Point(3, 3);
			this._pnlPlayClip.Name = "_pnlPlayClip";
			this._pnlPlayClip.Size = new System.Drawing.Size(195, 42);
			this._pnlPlayClip.TabIndex = 23;
			this._pnlPlayClip.Paint += new System.Windows.Forms.PaintEventHandler(this._pnlPlayClip_Paint);
			// 
			// _pnlProblemSummary
			// 
			this._pnlProblemSummary.AutoSize = true;
			this._pnlProblemSummary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._pnlProblemSummary.ColumnCount = 2;
			this._pnlProblemSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._pnlProblemSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._pnlProblemSummary.Controls.Add(this._problemIcon, 0, 0);
			this._pnlProblemSummary.Controls.Add(this._lblProblemSummary, 1, 0);
			this._pnlProblemSummary.Dock = System.Windows.Forms.DockStyle.Top;
			this._pnlProblemSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(17)))));
			this._pnlProblemSummary.Location = new System.Drawing.Point(10, 10);
			this._pnlProblemSummary.Name = "_pnlProblemSummary";
			this._pnlProblemSummary.Padding = new System.Windows.Forms.Padding(3);
			this._pnlProblemSummary.RowCount = 1;
			this._pnlProblemSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._pnlProblemSummary.Size = new System.Drawing.Size(657, 33);
			this._pnlProblemSummary.TabIndex = 24;
			this._pnlProblemSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintRoundedBorder);
			// 
			// ScriptTextHasChangedControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this._tableButtons);
			this.Controls.Add(this._masterTableLayoutPanel);
			this.Controls.Add(this._pnlProblemSummary);
			this.ForeColor = System.Drawing.Color.DarkGray;
			this.l10NSharpExtender1.SetLocalizableToolTip(this, null);
			this.l10NSharpExtender1.SetLocalizationComment(this, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this, "ScriptTextHasChangedControl.ScriptChangedControl");
			this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.MinimumSize = new System.Drawing.Size(0, 120);
			this.Name = "ScriptTextHasChangedControl";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(677, 545);
			((System.ComponentModel.ISupportInitialize)(iconShiftClips)).EndInit();
			this._masterTableLayoutPanel.ResumeLayout(false);
			this._masterTableLayoutPanel.PerformLayout();
			this._panelThen.ResumeLayout(false);
			this._panelThen.PerformLayout();
			this._tableOptions.ResumeLayout(false);
			this._tableOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._btnUseExisting)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._btnAskLater)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._btnDelete)).EndInit();
			this._flowNearbyText.ResumeLayout(false);
			this._flowNearbyText.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.l10NSharpExtender1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._problemIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._nextButton)).EndInit();
			this._tableButtons.ResumeLayout(false);
			this._tableButtons.PerformLayout();
			this._pnlPlayClip.ResumeLayout(false);
			this._pnlPlayClip.PerformLayout();
			this._pnlProblemSummary.ResumeLayout(false);
			this._pnlProblemSummary.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TableLayoutPanel _masterTableLayoutPanel;
		private L10NSharp.UI.L10NSharpExtender l10NSharpExtender1;
		private System.Windows.Forms.Label _lblBefore;
		private System.Windows.Forms.Label _lblRecordedDate;
		private System.Windows.Forms.Label _lblNow;
		private System.Windows.Forms.RichTextBox _txtThen;
		private System.Windows.Forms.RichTextBox _txtNow;
		private HearThis.UI.RadioButtonHelperButton _btnDelete;
		private System.Windows.Forms.FlowLayoutPanel _panelThen;
		private HearThis.UI.MouseSensitiveIconButton _nextButton;
		private System.Windows.Forms.Label _lblProblemSummary;
		private TableLayoutPanel _tableOptions;
		private RadioButton _rdoAskLater;
		private HearThis.UI.RadioButtonHelperButton _btnAskLater;
		private HearThis.UI.RadioButtonHelperButton _btnUseExisting;
		private RadioButton _rdoUseExisting;
		private RadioButton _rdoReRecord;
		private FlowLayoutPanel _flowNearbyText;
		private Label _lblShiftClips;
		private Button _btnShiftClips;
		private TableLayoutPanel _tableButtons;
		private FlowLayoutPanel _pnlPlayClip;
		private AudioButtonsControl _audioButtonsControl;
		private Button _btnPlayClip;
		private TableLayoutPanel _pnlProblemSummary;
		private PictureBox _problemIcon;
	}
}
