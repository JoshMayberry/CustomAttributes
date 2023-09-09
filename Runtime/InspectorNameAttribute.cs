using UnityEngine;

namespace jmayberry.CustomAttributes {

	public class InspectorNameAttribute : PropertyAttribute {
		public string NewName { get; private set; }

		public InspectorNameAttribute(string newName) {
			NewName = newName;
		}
	}
}