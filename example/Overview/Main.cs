// COPYRIGHT (C) Tom. ALL RIGHTS RESERVED.
// THE AntdUI PROJECT IS AN WINFORM LIBRARY LICENSED UNDER THE Apache-2.0 License.
// LICENSED UNDER THE Apache License, VERSION 2.0 (THE "License")
// YOU MAY NOT USE THIS FILE EXCEPT IN COMPLIANCE WITH THE License.
// YOU MAY OBTAIN A COPY OF THE LICENSE AT
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN WRITING, SOFTWARE
// DISTRIBUTED UNDER THE LICENSE IS DISTRIBUTED ON AN "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED.
// SEE THE LICENSE FOR THE SPECIFIC LANGUAGE GOVERNING PERMISSIONS AND
// LIMITATIONS UNDER THE License.
// GITEE: https://gitee.com/antdui/AntdUI
// GITHUB: https://github.com/AntdUI/AntdUI
// CSDN: https://blog.csdn.net/v_132
// QQ: 17379620

namespace Overview
{
    public partial class Main : AntdUI.Window
    {
        public Main(bool top)
        {
            InitializeComponent();
            TopMost = top;
            colorTheme.ValueChanged += ColorPicker1_ValueChanged;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            DraggableMouseDown();
            base.OnMouseDown(e);
        }

        private void Btn(object? sender, EventArgs e)
        {
            if (sender is Control control && control.Tag is IList tag)
            {
                Control? control_add = null;
                switch (tag.id)
                {
                    case "Button":
                        control_add = new Controls.Button(this);
                        break;
                    case "Avatar":
                        control_add = new Controls.Avatar(this);
                        break;
                    case "Carousel":
                        control_add = new Controls.Carousel(this);
                        break;
                    case "Badge":
                        control_add = new Controls.Badge(this);
                        break;
                    case "Checkbox":
                        control_add = new Controls.Checkbox(this);
                        break;
                    case "Radio":
                        control_add = new Controls.Radio(this);
                        break;
                    case "Input":
                        control_add = new Controls.Input(this);
                        break;
                    case "Select":
                        control_add = new Controls.Select(this);
                        break;
                    case "Panel":
                        control_add = new Controls.Panel(this);
                        break;
                    case "Progress":
                        control_add = new Controls.Progress(this);
                        break;
                    case "Result":
                        control_add = new Controls.Result(this);
                        break;
                    case "Tooltip":
                        control_add = new Controls.Tooltip(this);
                        break;
                    case "Divider":
                        control_add = new Controls.Divider(this);
                        break;
                    case "Slider":
                        control_add = new Controls.Slider(this);
                        break;
                    case "Tabs":
                        control_add = new Controls.Tabs(this);
                        break;
                    case "Switch":
                        control_add = new Controls.Switch(this);
                        break;
                    case "Pagination":
                        control_add = new Controls.Pagination(this);
                        break;
                    case "Alert":
                        control_add = new Controls.Alert(this);
                        break;
                    case "Message":
                        control_add = new Controls.Message(this);
                        break;
                    case "Notification":
                        control_add = new Controls.Notification(this);
                        break;
                    case "Menu":
                        control_add = new Controls.Menu(this);
                        break;
                    case "Segmented":
                        control_add = new Controls.Segmented(this);
                        break;
                    case "Modal":
                        control_add = new Controls.Modal(this);
                        break;
                    case "DatePicker":
                        control_add = new Controls.DatePicker(this);
                        break;
                    case "TimePicker":
                        control_add = new Controls.TimePicker(this);
                        break;
                    case "Dropdown":
                        control_add = new Controls.Dropdown(this);
                        break;
                    case "Tree":
                        control_add = new Controls.Tree(this);
                        break;
                    case "Popover":
                        control_add = new Controls.Popover(this);
                        break;
                    case "Timeline":
                        control_add = new Controls.Timeline(this);
                        break;
                    case "Steps":
                        control_add = new Controls.Steps(this);
                        break;
                    case "ColorPicker":
                        control_add = new Controls.ColorPicker(this);
                        break;
                    case "InputNumber":
                        control_add = new Controls.InputNumber(this);
                        break;
                    case "Tag":
                        control_add = new Controls.Tag(this);
                        break;
                    case "Drawer":
                        control_add = new Controls.Drawer(this);
                        break;
                    case "FloatButton":
                        FloatButton?.Close();
                        FloatButton = AntdUI.FloatButton.open(new AntdUI.FloatButton.Config(this, new AntdUI.FloatButton.ConfigBtn[] {
                            new AntdUI.FloatButton.ConfigBtn("id1", Properties.Resources.icon_search, true){
                                Tooltip = "搜索一下",
                                Type= AntdUI.TTypeMini.Primary
                            },
                            new AntdUI.FloatButton.ConfigBtn("id2", Properties.Resources.img1){
                                Badge = " ",
                                Tooltip = "笑死人",
                            },
                            new AntdUI.FloatButton.ConfigBtn("id3",Properties.Resources.icon_like, true){
                                Badge = "9",
                                Tooltip = "救救我"
                            },
                            new AntdUI.FloatButton.ConfigBtn("id4", Properties.Resources.icon_poweroff, true){
                                Badge = "99+",
                                Tooltip = "没救了",
                                Shape = AntdUI.TShape.Default,
                                Type= AntdUI.TTypeMini.Primary
                            }
                        }, btn =>
                        {
                            AntdUI.Message.info(this, "点击了：" + btn.Name, Font);
                        }));
                        break;
                    case "Rate":
                        control_add = new Controls.Rate(this);
                        break;
                    case "Table":
                        control_add = new Controls.Table(this);
                        break;
                    case "Image":
                        control_add = new Controls.Preview(this);
                        break;
                }
                if (control_add != null)
                {
                    btn_back.Tag = control_add;
                    BeginInvoke(() =>
                    {
                        flowPanel.Visible = false;
                        foreach (AntdUI.Panel c in flowPanel.Controls)
                        {
                            c.SetMouseHover(false);
                        }
                        control_add.Dock = DockStyle.Fill;
                        AutoDpi(control_add);
                        Controls.Add(control_add);
                        control_add.BringToFront();
                        control_add.Focus();
                        windowBar.UseLeft = btn_back.Width;
                        btn_back.Visible = true;
                    });
                }
            }
        }
        Form? FloatButton = null;

        private void btn_back_Click(object sender, EventArgs e)
        {
            BeginInvoke(() =>
            {
                if (btn_back.Tag is Control control)
                {
                    control.Dispose();
                    Controls.Remove(control);
                }
                btn_back.Visible = false;
                windowBar.UseLeft = 0;
                flowPanel.Visible = true;
            });
        }

        private void btn_mode_Click(object? sender, EventArgs e)
        {
            AntdUI.Config.IsDark = !AntdUI.Config.IsDark;
            Dark = AntdUI.Config.IsDark;
            if (Dark)
            {
                btn_mode.ImageSvg = Properties.Resources.app_dark;
                BackColor = Color.Black;
                ForeColor = Color.White;
            }
            else
            {
                btn_mode.ImageSvg = Properties.Resources.app_light;
                BackColor = Color.White;
                ForeColor = Color.Black;
            }
            foreach (AntdUI.Panel item in flowPanel.Controls)
            {
                foreach (Control control in item.Controls)
                {
                    if (control is PictureBox pic && pic.Tag is IList tag)
                    {
                        pic.Image = Dark ? tag.imgs[1] : tag.imgs[0];
                    }
                }
            }
            OnSizeChanged(e);
        }

        private void ColorPicker1_ValueChanged(object sender, Color value)
        {
            AntdUI.Style.Db.SetPrimary(value);
            Refresh();
        }

        #region 搜索

        private void txt_search_PrefixClick(object sender, MouseEventArgs e)
        {
            LoadSearchList();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadSearchList();
        }

        void LoadSearchList()
        {
            string search = txt_search.Text;
            windowBar.Loading = true;
            BeginInvoke(() =>
            {
                flowPanel.PauseLayout = true;
                if (string.IsNullOrEmpty(search))
                {
                    foreach (Control control in flowPanel.Controls)
                    {
                        control.Visible = true;
                    }
                }
                else
                {
                    string searchLower = search.ToLower();
                    foreach (Control control in flowPanel.Controls)
                    {
                        if (control.Tag is IList data)
                        {
                            control.Visible = data.id.Contains(search) || data.key.Contains(search) || data.keyword.Contains(searchLower) || data.keywordmini.Contains(searchLower);
                        }
                    }
                }
                flowPanel.PauseLayout = false;
                windowBar.Loading = false;
            });
        }

        #endregion

        #region 加载列表

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            windowBar.Loading = true;
            Task.Run(LoadList);
        }

        void LoadList()
        {
            var dpi = AntdUI.Config.Dpi;

            var dir = new IList[]
            {
                //通用
                new IList("Button","按钮", res_light.Button, res_dark.Button),
                new IList("FloatButton","悬浮按钮",res_light.FloatButton, res_dark.FloatButton),

                //布局
                new IList("Divider","分割线", res_light.Divider, res_dark.Divider),

                //导航
                new IList("Dropdown","下拉菜单", res_light.Dropdown, res_dark.Dropdown),
                new IList("Menu","导航菜单", res_light.Menu, res_dark.Menu),
                new IList("Pagination","分页",res_light.Pagination, res_dark.Pagination),
                new IList("Steps","步骤条",res_light.Steps, res_dark.Steps),

                //数据录入
                new IList("Checkbox","多选框", res_light.Checkbox, res_dark.Checkbox),
                new IList("ColorPicker","颜色选择器", res_light.ColorPicker, res_dark.ColorPicker),
                new IList("DatePicker","日期选择框", res_light.DatePicker, res_dark.DatePicker),
                new IList("Input","输入框", res_light.Input, res_dark.Input),
                new IList("InputNumber","数字输入框", res_light.InputNumber, res_dark.InputNumber),
                new IList("Radio","单选框", res_light.Radio, res_dark.Radio),
                new IList("Rate","评分", res_light.Rate, res_dark.Rate),
                new IList("Select","选择器", res_light.Select, res_dark.Select),
                new IList("Slider","滑动输入条",res_light.Slider, res_dark.Slider),
                new IList("Switch","开关",res_light.Switch, res_dark.Switch),
                new IList("TimePicker","时间选择框",res_light.TimePicker, res_dark.TimePicker),

                //数据展示
                new IList("Avatar","头像", res_light.Avatar, res_dark.Avatar),
                new IList("Badge","徽标数",res_light.Badge, res_dark.Badge),
                new IList("Panel","面板", res_light.Panel, res_dark.Panel),
                new IList("Carousel","走马灯",res_light.Carousel, res_dark.Carousel),
                new IList("Image","图片",res_light.Image, res_dark.Image),
                new IList("Popover","气泡卡片",res_light.Popover, res_dark.Popover),
                new IList("Segmented","分段控制器",res_light.Segmented, res_dark.Segmented),
                new IList("Table","表格",res_light.Table, res_dark.Table),
                new IList("Tabs","标签页",res_light.Tabs, res_dark.Tabs),
                new IList("Tag","标签",res_light.Tag, res_dark.Tag),
                new IList("Timeline","时间轴",res_light.Timeline, res_dark.Timeline),
                new IList("Tooltip","文字提示",res_light.Tooltip, res_dark.Tooltip),
                new IList("Tree","树形控件",res_light.Tree, res_dark.Tree),

                //反馈
                new IList("Alert","警告提示",res_light.Alert, res_dark.Alert),
                new IList("Drawer","抽屉",res_light.Drawer, res_dark.Drawer),
                new IList("Message","全局提示",res_light.Message, res_dark.Message),
                new IList("Modal","对话框",res_light.Modal, res_dark.Modal),
                new IList("Notification","通知提醒框",res_light.Notification, res_dark.Notification),
                new IList("Progress","进度条",res_light.Progress, res_dark.Progress),
                new IList("Result","结果",res_light.Result, res_dark.Result),
            };

            var panel_size = new Size((int)(258 * dpi), (int)(244 * dpi));
            int title_height = (int)(44 * dpi), size = (int)(10 * dpi), size2 = size * 2;

            BeginInvoke(() =>
            {
                flowPanel.PauseLayout = true;
                flowPanel.Controls.Clear();
                foreach (var item in dir)
                {
                    var panel = new AntdUI.Panel
                    {
                        BorderWidth = 1F,
                        Location = new Point(0, 0),
                        Margin = new Padding(0),
                        Shadow = 20,
                        Size = panel_size,
                        Tag = item
                    };
                    var pic = new PictureBox
                    {
                        BackColor = Color.Transparent,
                        Dock = DockStyle.Fill,
                        Image = Dark ? item.imgs[1] : item.imgs[0],
                        SizeMode = PictureBoxSizeMode.CenterImage,
                        Tag = item
                    };

                    var divider = new AntdUI.Divider
                    {
                        BackColor = Color.Transparent,
                        Dock = DockStyle.Top,
                        Margin = new Padding(size),
                        Size = new Size(0, 1),
                        Tag = item
                    };
                    var label = new Label
                    {
                        BackColor = Color.Transparent,
                        Dock = DockStyle.Top,
                        Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold, GraphicsUnit.Point),
                        Padding = new Padding(size2, 0, 0, 0),
                        Size = new Size(0, title_height),
                        Text = item.id + " " + item.key,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Tag = item
                    };
                    panel.Controls.Add(pic);
                    panel.Controls.Add(divider);
                    panel.Controls.Add(label);
                    pic.Click += Btn;
                    label.Click += Btn;
                    flowPanel.Controls.Add(panel);
                    panel.BringToFront();
                }
                flowPanel.PauseLayout = false;
                windowBar.Loading = false;
            });
        }

        class IList
        {
            public IList(string _id, string _key, string _img_light, string _img_dark)
            {
                id = _id;
                key = _key;
                keyword = _id.ToLower() + AntdUI.Pinyin.Pinyin.GetPinyin(_key).ToLower();
                keywordmini = AntdUI.Pinyin.Pinyin.GetInitials(_key).ToLower();
                imgs = new Image[] { AntdUI.SvgExtend.SvgToBmp(_img_light), AntdUI.SvgExtend.SvgToBmp(_img_dark) };
            }
            public string id { get; set; }
            public string keyword { get; set; }
            public string keywordmini { get; set; }
            public string key { get; set; }
            public Image[] imgs { get; set; }
        }

        #endregion
    }
}