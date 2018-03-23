using System;

namespace WinFormBaiduMap
{
    /// <summary>
    /// 地图经纬度
    /// </summary>
    [Serializable]
    public class BaiduMapLngLat
    {
        /// <summary>
        /// 经度
        /// </summary>
        public double Lng { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public double Lat { get; set; }
        public BaiduMapLngLat() { }
        public BaiduMapLngLat(double lng, double lat)
        {
            Lng = lng;
            Lat = lat;
        }
    }
}
