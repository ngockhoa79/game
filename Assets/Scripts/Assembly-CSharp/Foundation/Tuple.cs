namespace Foundation
{
	public class Tuple<T1, T2>
	{
		public T1 Val1 { get; set; }

		public T2 Val2 { get; set; }

		public Tuple()
		{
		}

		public Tuple(T1 t1, T2 t2)
		{
		}

		public static bool operator ==(Tuple<T1, T2> t1, Tuple<T1, T2> t2)
		{
			return false;
		}

		public static bool operator !=(Tuple<T1, T2> t1, Tuple<T1, T2> t2)
		{
			return false;
		}
	}
	public class Tuple<T1, T2, T3>
	{
		public T1 Val1 { get; set; }

		public T2 Val2 { get; set; }

		public T3 Val3 { get; set; }

		public Tuple()
		{
		}

		public Tuple(T1 t1, T2 t2, T3 t3)
		{
		}

		public static bool operator ==(Tuple<T1, T2, T3> t1, Tuple<T1, T2, T3> t2)
		{
			return false;
		}

		public static bool operator !=(Tuple<T1, T2, T3> t1, Tuple<T1, T2, T3> t2)
		{
			return false;
		}
	}
}
