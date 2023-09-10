using UnityEngine;

namespace jmayberry.CustomAttributes {

	public class InspectorRenameAttribute : PropertyAttribute {
		public string NewName { get; private set; }

		public InspectorRenameAttribute(string newName) {
			NewName = newName;
		}
	}
}