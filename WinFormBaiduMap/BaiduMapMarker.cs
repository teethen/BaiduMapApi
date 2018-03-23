using System;

namespace WinFormBaiduMap
{
    /// <summary>
    /// 地图标注点
    /// </summary>
    [Serializable]
    public class BaiduMapMarker
    {
        /// <summary>
        /// 经度
        /// </summary>
        public double Lng { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public double Lat { get; set; }

        /// <summary>
        /// 标注点上面的label
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// 点击标注点 弹出信息窗口中的内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 标注点图标(图片路径) [说明：Icon 与 Color 二选一]
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 标注点图标颜色 [说明：Color 与 Icon 二选一]
        /// </summary>
        public string Color { get; set; }
                
        private bool animation = false;
        /// <summary>
        /// 标注点是否bmap动画跳动,默认false
        /// </summary>
        public bool Animation
        {
            get { return animation; }
            set { animation = value; }
        }

        public BaiduMapMarker() { }
        public BaiduMapMarker(double lng, double lat, string content, string icon, string color, bool anim = false)
        {
            Lng = lng;
            Lat = lat;
            Content = content;
            Icon = icon;
            Color = color;
            Animation = anim;
        }
    }
}
