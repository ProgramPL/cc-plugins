//debug plugin
using System;
namespace MCGalaxy {
	public class Example : Plugin {
		public override string name { get { return "ScriptDebug"; } }
		public override string website { get { return "www.github.com/TheMegaPVP"; } }
		public override string MCGalaxy_Version { get { return "1.9.3.0"; } }
		public override int build { get { return 100; } }
		public override string welcome { get { return "Succesfully Loaded Message"; } }
		public override string creator { get { return "MegaPVP"; } }
		public override bool LoadAtStartup { get { return true; } }

		public override void Load(bool startup) {
			//LOAD YOUR PLUGIN WITH EVENTS OR OTHER THINGS!
		}
                        
		public override void Unload(bool shutdown) {
			//UNLOAD YOUR PLUGIN BY SAVING FILES OR DISPOSING OBJECTS!
		}
                        
		public override void Help(Player p) {
			//HELP INFO!
		}
	}
}
