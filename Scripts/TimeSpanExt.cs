//using System;

//namespace Kogane
//{
//	/// <summary>
//	/// TimeSpan 型の拡張メソッドを管理するクラス
//	/// </summary>
//	public static class TimeSpanExt
//	{
//		//================================================================================
//		// 関数(static)
//		//================================================================================
//		/// <summary>
//		/// yyyy/MM/dd HH:mm:ss 形式の文字列に変換して返します
//		/// </summary>
//		public static string ToPattern( this TimeSpan self )
//		{
//			return new DateTime( self.Ticks ).ToString( "yyyy/MM/dd HH:mm:ss" );
//		}

//		/// <summary>
//		/// yyyy/MM/dd 形式の文字列に変換して返します
//		/// </summary>
//		public static string ToShortDatePattern( this TimeSpan self )
//		{
//			return new DateTime( self.Ticks ).ToString( "yyyy/MM/dd" );
//		}

//		/// <summary>
//		/// yyyy年M月d日 形式の文字列に変換して返します
//		/// </summary>
//		public static string ToLongDatePattern( this TimeSpan self )
//		{
//			return new DateTime( self.Ticks ).ToString( "yyyy年M月d日" );
//		}

//		/// <summary>
//		/// yyyy年M月d日 HH:mm:ss 形式の文字列に変換して返します
//		/// </summary>
//		public static string ToFullDateTimePattern( this TimeSpan self )
//		{
//			return new DateTime( self.Ticks ).ToString( "yyyy年M月d日 HH:mm:ss" );
//		}

//		/// <summary>
//		/// MM/dd HH:mm 形式の文字列に変換して返します
//		/// </summary>
//		public static string ToMiddleDateTimePattern( this TimeSpan self )
//		{
//			return new DateTime( self.Ticks ).ToString( "MM/dd HH:mm" );
//		}

//		/// <summary>
//		/// HH:mm 形式の文字列に変換して返します
//		/// </summary>
//		public static string ToShortTimePattern( this TimeSpan self )
//		{
//			return new DateTime( self.Ticks ).ToString( "HH:mm" );
//		}

//		/// <summary>
//		/// HH:mm:ss 形式の文字列に変換して返します
//		/// </summary>
//		public static string ToLongTimePattern( this TimeSpan self )
//		{
//			return new DateTime( self.Ticks ).ToString( "HH:mm:ss" );
//		}
//	}
//}