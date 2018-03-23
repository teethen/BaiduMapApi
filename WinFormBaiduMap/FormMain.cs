using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Permissions;
using System.Windows.Forms;
using WinFormBaiduMap;

namespace WindowsFormsApp1
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class FormMain : Form
    {
        private static string MAP_BAIDU_HTML = "";

        public FormMain()
        {
            InitializeComponent();

            MAP_BAIDU_HTML = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mapapi"), "baidu.html");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //初始化浏览器
            BaiduMapUtil.InitWebBrowser(webBrowser1);
            //webBrowser1.ObjectForScripting = this;
        }

        private void buttonBasic_Click(object sender, EventArgs e)
        {
            //郑州
            int zoom = 12;          //地图 缩放级别
            double lng = 113.663221;//中心点 经度
            double lat = 34.7568711;//中心点 纬度

            BaiduMapUtil.MapBasic(webBrowser1, lng, lat, zoom);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            //北京
            int zoom = 15;
            double lng = 116.417854;
            double lat = 39.921988;

            List<BaiduMapMarker> list = new List<BaiduMapMarker>() {
                new BaiduMapMarker
                {
                    Lng = 116.406605,
                    Lat = 39.921585,
                    Label = "李彬：2个待办工单",
                    Content = "梅河口市红梅镇供电所 李彬：2个待办工单，剩余49分钟",
                    Color = "#000"
                },
                new BaiduMapMarker
                {
                    Lng = 116.412222,
                    Lat = 39.912345,
                    Label = "付祥：3个待办工单",
                    Content = "梅河口市红梅镇供电所 付祥：3个待办工单，剩余89分钟",
                    Color = "green"
                },
                new BaiduMapMarker
                {
                    Lng = 116.417854,
                    Lat = 39.921988,
                    Label = "田野：1个待办工单",
                    Content = "梅河口市供电有限公司 田野：1个待办工单，剩余19分钟",
                    Color = "red",
                    Animation = true
                }
            };

            BaiduMapUtil.MapInfoWindow(webBrowser1, lng, lat, zoom, list);
        }

        private void buttonTrack_Click(object sender, EventArgs e)
        {
            //深圳
            int zoom = 15;
            double lng = 114.055235;
            double lat = 22.381754;
            double beginLng = 114.00100;
            double beginLat = 22.550000;
            double endLng = 113.95100;
            double endLat = 22.550000;

            string linecolor = "purple";

            List<BaiduMapLngLat> list = new List<BaiduMapLngLat>() {
                new BaiduMapLngLat(114.00100, 22.550000),
                new BaiduMapLngLat(114.00130, 22.550000),
                new BaiduMapLngLat(114.00160, 22.550000),
                new BaiduMapLngLat(114.00200, 22.550000),
                new BaiduMapLngLat(114.00300, 22.550500),
                new BaiduMapLngLat(114.00400, 22.550000),
                new BaiduMapLngLat(114.00500, 22.550000),
                new BaiduMapLngLat(114.00505, 22.549800),
                new BaiduMapLngLat(114.00510, 22.550000),
                new BaiduMapLngLat(114.00515, 22.550000),
                new BaiduMapLngLat(114.00525, 22.550400),
                new BaiduMapLngLat(114.00537, 22.549500)
            };
            //画轨迹
            BaiduMapUtil.MapTracker(webBrowser1, lng, lat, zoom, linecolor, list, beginLng, beginLat, endLng, endLat);
        }

        private void buttonTrackPoly_Click(object sender, EventArgs e)
        {
            //北京
            int zoom = 14;
            double lng = 116.404;
            double lat = 39.915;

            string linecolor = "#f03";
            string iconcolor = null;

            List<BaiduMapLngLat> list = new List<BaiduMapLngLat>() {
                new BaiduMapLngLat(116.350658,39.938285),
                new BaiduMapLngLat(116.386446,39.939281),
                new BaiduMapLngLat(116.389034,39.913828),
                new BaiduMapLngLat(116.442501,39.914603)
            };

            //画折线轨迹
            BaiduMapUtil.MapTrackerPoly(webBrowser1, lng, lat, zoom, linecolor, iconcolor, list);
        }
    }
}
