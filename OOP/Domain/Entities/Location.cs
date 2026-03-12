namespace OOP.Domain.Entities
{
    public class Location
    {
        // Tên địa điểm (Vd: Nhà riêng, Công ty, Landmark 81, Trường Đại học Bách Khoa)
        public string Label { get; init; }

        // Địa chỉ chi tiết: "268 Lý Thường Kiệt, Quận 10, TP.HCM"
        public string Address { get; init; }

        public double Lat { get; init; }
        public double Lng { get; init; }

        public Location(string label, string address, double lat, double lng)
        {
            if (string.IsNullOrWhiteSpace(label))
                throw new ArgumentException("Nhãn địa điểm không được để trống.");

            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Địa chỉ không được để trống.");

            // Kiểm tra tính hợp lệ của tọa độ thực tế
            if (lat < -90 || lat > 90)
                throw new ArgumentOutOfRangeException(nameof(Lat), "Vĩ độ phải từ -90 đến 90.");

            if (lng < -180 || lng > 180)
                throw new ArgumentOutOfRangeException(nameof(lng), "Kinh độ phải từ -180 đến 180.");

            Label = label;
            Address = address;
            Lat = lat;
            Lng = lng;
        }
        
    }
}