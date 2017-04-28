using System;
using System.Threading;

namespace ns11
{
	public class Class154 : IDisposable
	{
		private IntPtr _intptr0;

		private Class156 _class1560;

		private Class156 _class1561;

		private Thread _thread0;

		private Delegate2 _delegate20;

		private bool _bool0;

		~Class154()
		{
			Dispose();
		}

		public void Dispose()
		{
			if (_thread0 != null)
			{
				try
				{
					_bool0 = true;
					if (_intptr0 != IntPtr.Zero)
					{
						Class162.waveInReset(_intptr0);
					}
					method_1();
					_thread0.Join();
					_delegate20 = null;
					method_0();
					if (_intptr0 != IntPtr.Zero)
					{
						Class162.waveInClose(_intptr0);
					}
				}
				finally
				{
					_thread0 = null;
					_intptr0 = IntPtr.Zero;
				}
			}
			GC.SuppressFinalize(this);
		}

		private void method_0()
		{
			_class1561 = null;
			if (_class1560 != null)
			{
				var @class = _class1560;
				_class1560 = null;
				var class2 = @class;
				do
				{
					var class3 = class2.Class1560;
					class2.Dispose();
					class2 = class3;
				}
				while (class2 != @class);
			}
		}

		private void method_1()
		{
			var @class = _class1560;
			while (@class.Class1560 != _class1560)
			{
				@class.method_0();
				@class = @class.Class1560;
			}
		}
	}
}
