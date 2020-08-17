using System;

namespace Kogane
{
	/// <summary>
	/// DateTime 型の拡張メソッドを管理するクラス
	/// </summary>
	public static class DateTimeExt
	{
		//================================================================================
		// 関数(static)
		//================================================================================
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