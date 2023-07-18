namespace XMLLanguageInterpreter.TypeLoaders
{
	public interface IXMLConstant
	{
		public abstract static Type GetCSharpType(string typeName);

		public abstract static T ParseDefult<T>(string dataToParse);
	}
}
