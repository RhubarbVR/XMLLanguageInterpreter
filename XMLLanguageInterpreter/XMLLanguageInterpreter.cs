using System.Xml.Linq;

namespace XMLLanguageInterpreter
{
	public sealed class XMLLanguageInterpreter<IXMLConstant, IXMLMethodCaller>
		where IXMLConstant : class, TypeLoaders.IXMLConstant
		where IXMLMethodCaller : class, TypeLoaders.IXMLMethodCaller

	{
		public static XMLLanguageInterpreter<IXMLConstant, IXMLMethodCaller> LoadScript(string xDocument) {
			return LoadScript(XDocument.Parse(xDocument));
		}

		public static XMLLanguageInterpreter<IXMLConstant, IXMLMethodCaller> LoadScript(XDocument xDocument) {
			var newScirpt = new XMLLanguageInterpreter<IXMLConstant, IXMLMethodCaller>();
			newScirpt.UpdateScript(xDocument);
			return newScirpt;
		}

		public void UpdateScript(XDocument document) {
			Unload();

		}

		public void Unload() {

		}
	}
}