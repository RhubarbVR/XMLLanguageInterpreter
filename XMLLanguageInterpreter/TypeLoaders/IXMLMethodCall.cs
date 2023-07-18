namespace XMLLanguageInterpreter.TypeLoaders
{

	public interface IXMLMethodCaller
	{
		public abstract static T GetMethodFunc<T>(Type targetType, string methodName,bool isStatic) where T : Delegate;
	}

}
