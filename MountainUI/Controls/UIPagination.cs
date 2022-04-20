using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mountain.UI
{
    public partial class UIPagination : Control
    {
        public UIPagination()
        {
            InitializeComponent();
        }

        public UIPagination(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        ///// <summary>
        ///// 翻页事件委托
        ///// </summary>
        ///// <param name="pageIndex"></param>
        ///// <param name="pageSize"></param>
        ///// <param name="pageCount"></param>
        //public delegate void OnPageChanged(int pageIndex, int pageSize);
        ///// <summary>
        ///// 翻页事件
        ///// </summary>
        //[Browsable(true), Description("页码变更事件")]
        //public event OnPageChanged PageChanged;

        //public UIPagerMeta()
        //{
        //    InitializeComponent();
        //    pageTotalCount = Convert.ToInt32(Math.Floor((double)totalCount / (double)pageSize));
        //    btnPrev.Click += BtnPrev_Click;
        //    btnNext.Click += BtnNext_Click;
        //    SetPage();
        //}

        //private class Page
        //{
        //    public int PageNum;
        //    public bool IsOmit;
        //}

        //private List<string> ctrls = new List<string>();
        //private void SetPage()
        //{
        //    //移除废弃按钮
        //    foreach (var item in ctrls)
        //    {
        //        this.Controls.RemoveByKey(item);
        //    }
        //    ctrls.Clear();

        //    bool isAddOmitCtrl = pageTotalCount > pagerCount;     //是否添加省略符
        //    List<Page> showPage = new List<Page>();                 //显示的页码数组
        //    List<int> omitPage = new List<int>();                   //显示为省略符号的页码数组

        //    int startNum = 2;
        //    int endNum = pagerCount;

        //    if (isAddOmitCtrl)
        //    {
        //        if (pageActive <= pagerCount - 2)
        //        {
        //            startNum = 2;
        //            endNum = pagerCount - 1;
        //            omitPage.Add(endNum);
        //        }
        //        else
        //        {
        //            if (pageActive + (pagerCount - 4) >= pageTotalCount)
        //            {
        //                startNum = pageTotalCount - (pagerCount - 2);
        //                endNum = pageTotalCount - 1;
        //                omitPage.Add(startNum);
        //            }
        //            else
        //            {
        //                int offset = (int)(Math.Ceiling((double)(pagerCount - 4) / 2));
        //                startNum = pageActive - offset;
        //                endNum = pageActive + offset;
        //                omitPage.Add(startNum);
        //                omitPage.Add(endNum);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        startNum = 2;
        //        endNum = pageTotalCount - 1;
        //    }

        //    //处理显示的页码
        //    showPage.Add(new Page() { PageNum = 1, IsOmit = false });
        //    for (int i = startNum; i <= endNum; i++)
        //    {
        //        bool isOmit = omitPage.Contains(i);
        //        showPage.Add(new Page() { PageNum = i, IsOmit = isOmit });
        //    }
        //    showPage.Add(new Page() { PageNum = pageTotalCount, IsOmit = false });

        //    //设置翻页按钮位置
        //    this.btnPrev.Size = this.btnNext.Size = pageBtnSize;
        //    this.btnPrev.Location = new Point(pageBtnSpace, (this.Height - pageBtnSize.Height) / 2);
        //    this.btnNext.Location = new Point((showPage.Count + 1) * (pageBtnSize.Width + pageBtnSpace) + pageBtnSpace, (this.Height - pageBtnSize.Height) / 2);

        //    //生成页码
        //    int num = 1;
        //    foreach (Page item in showPage)
        //    {
        //        Color FillColor = item.PageNum != pageActive ? pageBtnBackColor : pageBtnActiveBackColor;
        //        Color ForeColor = item.PageNum != pageActive ? pageBtnForeColor : pageBtnActiveForeColor;
        //        UIButton btn = new UIButton();
        //        btn.Tag = item.PageNum;
        //        btn.Name = "page" + item.PageNum;
        //        btn.Text = item.IsOmit ? "…" : item.PageNum.ToString();
        //        btn.Radius = pageBtnRadius;
        //        btn.Size = pageBtnSize;
        //        btn.Location = new Point(num++ * (pageBtnSize.Width + pageBtnSpace) + pageBtnSpace, (this.Height - pageBtnSize.Height) / 2);
        //        btn.Font = this.Font;
        //        btn.ForeColor = ForeColor;
        //        btn.ForeHoverColor = pageBtnHoverForeColor;
        //        btn.FillColor = FillColor;
        //        btn.FillHoverColor = pageBtnHoverBackColor;
        //        btn.FillPressColor = pageBtnHoverBackColor;
        //        btn.RectColor = Color.Transparent;
        //        btn.RectHoverColor = Color.Transparent;
        //        btn.RectPressColor = Color.Transparent;
        //        btn.BackColor = Color.Transparent;
        //        btn.RectSides = ToolStripStatusLabelBorderSides.None;
        //        btn.Style = UIStyle.Custom;
        //        btn.StyleCustomMode = true;
        //        btn.Click += Btn_Click;
        //        ctrls.Add("page" + item.PageNum);
        //        this.Controls.Add(btn);
        //    }
        //    int newWidth = (showPage.Count + 2) * (pageBtnSize.Width + pageBtnSpace) + pageBtnSpace;
        //    //是否使用右侧停靠
        //    if (isDockRight)
        //    {
        //        this.Location = new Point(this.Location.X - (newWidth - this.Width), this.Location.Y);
        //    }
        //    //自动设置控件大小
        //    this.Width = newWidth;
        //}

        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);

        //}

        ///// <summary>
        ///// 分页按钮事件
        ///// </summary>
        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    UIButton btn = (UIButton)sender;
        //    pageActive = (int)btn.Tag;
        //    SetPage();
        //    if (PageChanged != null)
        //    {
        //        PageChanged(pageActive, pageSize);
        //    }
        //}
        ///// <summary>
        ///// 上一页事件
        ///// </summary>
        //private void BtnPrev_Click(object sender, EventArgs e)
        //{
        //    if (pageActive - 1 >= 1)
        //    {
        //        Control[] ctrls = Controls.Find("page" + (pageActive - 1), false);
        //        if (ctrls.Length > 0)
        //        {
        //            UIButton btnActive = (UIButton)ctrls[0];
        //            btnActive.PerformClick();
        //        }
        //    }
        //}
        ///// <summary>
        ///// 下一页事件
        ///// </summary>
        //private void BtnNext_Click(object sender, EventArgs e)
        //{
        //    if (pageActive + 1 <= pageTotalCount)
        //    {
        //        Control[] ctrls = Controls.Find("page" + (pageActive + 1), false);
        //        if (ctrls.Length > 0)
        //        {
        //            UIButton btnActive = (UIButton)ctrls[0];
        //            btnActive.PerformClick();
        //        }
        //    }
        //}

        ///// <summary>
        ///// 数据量总数
        ///// </summary>
        //private int totalCount = 200;
        ///// <summary>
        ///// 总页数
        ///// </summary>
        //public int pageTotalCount = 0;
        ///// <summary>
        ///// 每页显示数量
        ///// </summary>
        //private int pageSize = 10;
        ///// <summary>
        ///// 当前显示页码
        ///// </summary>
        //private int pageActive = 1;
        ///// <summary>
        ///// 按钮最大显示数量
        ///// </summary>
        //private int pagerCount = 7;
        ///// <summary>
        ///// 按钮背景颜色
        ///// </summary>
        //private Color pageBtnBackColor = Color.FromArgb(45, 45, 45);
        ///// <summary>
        ///// 按钮字体颜色
        ///// </summary>
        //private Color pageBtnForeColor = Color.FromArgb(116, 118, 124);
        ///// <summary>
        ///// 当前操作按钮背景颜色
        ///// </summary>
        //private Color pageBtnActiveBackColor = Color.FromArgb(0, 160, 216);
        ///// <summary>
        ///// 当前操作字体颜色
        ///// </summary>
        //private Color pageBtnActiveForeColor = Color.White;
        ///// <summary>
        ///// 按钮浮动背景色
        ///// </summary>
        //private Color pageBtnHoverBackColor = Color.FromArgb(0, 160, 216);
        ///// <summary>
        ///// 按钮浮动字体颜色
        ///// </summary>
        //private Color pageBtnHoverForeColor = Color.White;
        ///// <summary>
        ///// 按钮间距
        ///// </summary>
        //private int pageBtnSpace = 5;
        ///// <summary>
        ///// 按钮尺寸
        ///// </summary>
        //private Size pageBtnSize = new Size(30, 30);
        ///// <summary>
        ///// 按钮圆角弧度
        ///// </summary>
        //private int pageBtnRadius = 15;
        ///// <summary>
        ///// 是否按右侧停靠
        ///// </summary>
        //private bool isDockRight = false;

        //#region --------------------封装属性--------------------
        ///// <summary>
        ///// 数据量总数
        ///// </summary>
        //[Browsable(true), DefaultValue(100), Description("数据量总数")]
        //public int TotalCount
        //{
        //    get => totalCount;
        //    set
        //    {
        //        totalCount = value;
        //        pageTotalCount = Convert.ToInt32(Math.Ceiling((double)value / (double)pageSize));
        //        SetPage();
        //    }
        //}
        ///// <summary>
        ///// 总页数
        ///// </summary>
        //[Browsable(false)]
        //public int PageTotalCount { get => totalCount; set => totalCount = value; }
        ///// <summary>
        ///// 每页显示数量
        ///// </summary>
        //[Browsable(true), DefaultValue(10), Description("每页显示数量")]
        //public int PageSize
        //{
        //    get => pageSize;
        //    set
        //    {
        //        pageSize = value;
        //        pageTotalCount = Convert.ToInt32(Math.Ceiling((double)totalCount / (double)value));
        //        SetPage();
        //    }
        //}
        ///// <summary>
        ///// 当前操作页码
        ///// </summary>
        //[Browsable(true), DefaultValue(1), Description("当前操作页码")]
        //public int PageActive { get => pageActive; set { pageActive = value; SetPage(); } }
        ///// <summary>
        ///// 最大显示按钮数量
        ///// </summary>
        //[Browsable(true), DefaultValue(7), Description("最大显示按钮数量")]
        //public int PagerCount { get => pagerCount; set { pagerCount = value; SetPage(); } }
        ///// <summary>
        ///// 按钮背景颜色
        ///// </summary>
        //[Browsable(true), DefaultValue(typeof(Color), "45, 45, 45"), Description("按钮背景颜色")]
        //public Color PageBtnBackColor { get => pageBtnBackColor; set { pageBtnBackColor = value; SetPage(); } }
        ///// <summary>
        ///// 按钮字体颜色
        ///// </summary>
        //[Browsable(true), DefaultValue(typeof(Color), "116, 118, 124"), Description("按钮字体颜色")]
        //public Color PageBtnForeColor { get => pageBtnForeColor; set { pageBtnForeColor = value; SetPage(); } }
        ///// <summary>
        ///// 操作按钮背景颜色
        ///// </summary>
        //[Browsable(true), DefaultValue(typeof(Color), "0, 160, 216"), Description("操作按钮背景颜色")]
        //public Color PageBtnActiveBackColor { get => pageBtnActiveBackColor; set { pageBtnActiveBackColor = value; SetPage(); } }
        ///// <summary>
        ///// 操作按钮字体颜色
        ///// </summary>
        //[Browsable(true), DefaultValue(typeof(Color), "White"), Description("操作按钮字体颜色")]
        //public Color PageBtnActiveForeColor { get => pageBtnActiveForeColor; set { pageBtnActiveForeColor = value; SetPage(); } }
        ///// <summary>
        ///// 按钮浮动背景颜色
        ///// </summary>
        //[Browsable(true), DefaultValue(typeof(Color), "0, 160, 216"), Description("按钮浮动背景颜色")]
        //public Color PageBtnHoverBackColor { get => pageBtnHoverBackColor; set => pageBtnHoverBackColor = value; }
        ///// <summary>
        ///// 按钮浮动字体颜色
        ///// </summary>
        //[Browsable(true), DefaultValue(typeof(Color), "White"), Description("按钮浮动字体颜色")]
        //public Color PageBtnHoverForeColor { get => pageBtnHoverForeColor; set => pageBtnHoverForeColor = value; }
        ///// <summary>
        ///// 按钮间距
        ///// </summary>
        //[Browsable(true), DefaultValue(5), Description("按钮间距")]
        //public int PageBtnSpace { get => pageBtnSpace; set { pageBtnSpace = value; SetPage(); } }
        ///// <summary>
        ///// 按钮尺寸
        ///// </summary>
        //[Browsable(true), DefaultValue(typeof(Size), "30, 30"), Description("按钮尺寸")]
        //public Size PageBtnSize { get => pageBtnSize; set { pageBtnSize = value; SetPage(); } }
        ///// <summary>
        ///// 按钮圆角弧度
        ///// </summary>
        //[Browsable(true), DefaultValue(15), Description("按钮圆角弧度")]
        //public int PageBtnRadius { get => pageBtnRadius; set => pageBtnRadius = value; }
        ///// <summary>
        ///// 是否按右侧停靠并更新位置
        ///// </summary>
        //[Browsable(true), DefaultValue(false), Description("是否按右侧停靠并更新location")]
        //public bool IsDockRight { get => isDockRight; set => isDockRight = value; }


        //#endregion

    }
}
