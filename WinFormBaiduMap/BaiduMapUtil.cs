using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace WinFormBaiduMap
{
    public class BaiduMapUtil
    {
        private static JavaScriptSerializer serializer;                

        /// <summary>
        /// 初始化浏览器
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="html">html路径</param>
        public static void InitWebBrowser(WebBrowser browser, string html = "")
        {
            if (serializer == null)
            {
                serializer = new JavaScriptSerializer();
            }
            if(string.IsNullOrEmpty(html))
            {
                html = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mapapi"), "baidu.html");
            }

            browser.ScriptErrorsSuppressed = true;
            browser.AllowWebBrowserDrop = false;
            browser.WebBrowserShortcutsEnabled = false;
            browser.IsWebBrowserContextMenuEnabled = false;
            browser.Navigate(html);
        }

        /// <summary>
        /// 展示基本地图
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="lng">中心点经度</param>
        /// <param name="lat">中心点纬度</param>
        /// <param name="zoom">地图缩放级别</param>
        public static void MapBasic(WebBrowser browser, double lng, double lat, int zoom)
        {
            browser.Document.InvokeScript("mapBasic", new object[] { lng, lat, zoom });
        }

        /// <summary>
        /// 标注点信息窗口
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="lng">中心点经度</param>
        /// <param name="lat">中心点纬度</param>
        /// <param name="zoom">地图缩放级别</param>
        /// <param name="list">信息窗口内容</param>
        public static void MapInfoWindow(WebBrowser browser, double lng, double lat, int zoom, List<BaiduMapMarker> list)
        {
            string data_info_json = serializer.Serialize(list);

            browser.Document.InvokeScript("mapInfoWindow", new object[] { lng, lat, zoom, data_info_json });
        }

        /// <summary>
        /// 绘制轨迹
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="lng">中心点经度</param>
        /// <param name="lat">中心点经度</param>
        /// <param name="zoom">地图缩放级别</param>
        /// <param name="linecolor">轨迹线颜色</param>
        /// <param name="list">轨迹坐标点列表</param>
        /// <param name="beginLng">轨迹开始点经度</param>
        /// <param name="beginLat">轨迹开始点纬度</param>
        /// <param name="endLng">轨迹结束点经度</param>
        /// <param name="endLat">轨迹结束点纬度</param>
        public static void MapTracker(WebBrowser browser, double lng, double lat, int zoom, string linecolor, List<BaiduMapLngLat> list, double beginLng, double beginLat, double endLng, double endLat)
        {
            string points_json = serializer.Serialize(list);

            string beginLngLat = String.Join(",", beginLng, beginLat);
            string endLngLat = String.Join(",", endLng, endLat);

            linecolor = string.IsNullOrEmpty(linecolor) ? BaiduMapColor.BLACK : linecolor;

            browser.Document.InvokeScript("mapTracker", new object[] { lng, lat, zoom, linecolor, points_json, beginLngLat, endLngLat });
        }

        /// <summary>
        /// 绘制折线轨迹
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="lng">中心点经度</param>
        /// <param name="lat">中心点经度</param>
        /// <param name="zoom">地图缩放级别</param>
        /// <param name="linecolor">轨迹线颜色</param>
        /// <param name="iconcolor">折线矢量图标颜色</param>
        /// <param name="list">轨迹坐标点列表</param>
        public static void MapTrackerPoly(WebBrowser browser, double lng, double lat, int zoom, string linecolor, string iconcolor, List<BaiduMapLngLat> list)
        {
            string points_json = serializer.Serialize(list);

            linecolor = string.IsNullOrEmpty(linecolor) ? BaiduMapColor.BLACK : linecolor;
            iconcolor = string.IsNullOrEmpty(iconcolor) ? BaiduMapColor.WHITE : iconcolor;

            browser.Document.InvokeScript("mapTrackerPoly", new object[] { lng, lat, zoom, linecolor, iconcolor, points_json });
        }
    }
}
