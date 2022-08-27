using System;

namespace Kogane
{
    /// <summary>
    /// DateTime 型の拡張メソッドを管理するクラス
    /// </summary>
    public static class DateTimeExtensionMethods
    {
        //================================================================================
        // 定数(static readonly)
        //================================================================================
        private static readonly DateTime UNIX_EPOCH = new
        (
            year: 1970,
            month: 1,
            day: 1,
            hour: 0,
            minute: 0,
            second: 0,
            kind: DateTimeKind.Utc
        );

        //================================================================================
        // プロパティ
        //================================================================================
        public static DateTime UnixEpoch => UNIX_EPOCH;

        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// 1970-01-01T00:00:00Z からの経過時間を秒で返します
        /// </summary>
        public static long ToUnixTime( this DateTime self )
        {
            return ( long )self.Subtract( UNIX_EPOCH ).TotalSeconds;
        }

        /// <summary>
        /// 1970-01-01T00:00:00Z からの経過時間を秒で示す Unix 時間を DateTime 値に変換します
        /// </summary>
        public static DateTime FromUnixTime( long unixTime )
        {
            return UNIX_EPOCH.AddSeconds( unixTime ).ToLocalTime();
        }

        /// <summary>
        /// yyyy/MM/dd HH:mm:ss 形式の文字列に変換して返します
        /// </summary>
        public static string ToPattern( this DateTime self )
        {
            return self.ToString( "yyyy/MM/dd HH:mm:ss" );
        }

        /// <summary>
        /// yyyy/MM/dd 形式の文字列に変換して返します
        /// </summary>
        public static string ToShortDatePattern( this DateTime self )
        {
            return self.ToString( "yyyy/MM/dd" );
        }

        /// <summary>
        /// yyyy年M月d日 形式の文字列に変換して返します
        /// </summary>
        public static string ToLongDatePattern( this DateTime self )
        {
            return self.ToString( "yyyy年M月d日" );
        }

        /// <summary>
        /// yyyy年M月d日 HH:mm:ss 形式の文字列に変換して返します
        /// </summary>
        public static string ToFullDateTimePattern( this DateTime self )
        {
            return self.ToString( "yyyy年M月d日 HH:mm:ss" );
        }

        /// <summary>
        /// MM/dd HH:mm 形式の文字列に変換して返します
        /// </summary>
        public static string ToMiddleDateTimePattern( this DateTime self )
        {
            return self.ToString( "MM/dd HH:mm" );
        }

        /// <summary>
        /// HH:mm 形式の文字列に変換して返します
        /// </summary>
        public static string ToShortTimePattern( this DateTime self )
        {
            return self.ToString( "HH:mm" );
        }

        /// <summary>
        /// HH:mm:ss 形式の文字列に変換して返します
        /// </summary>
        public static string ToLongTimePattern( this DateTime self )
        {
            return self.ToString( "HH:mm:ss" );
        }
    }
}