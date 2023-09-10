using UnityEditor;
using UnityEngine;

namespace jmayberry.CustomAttributes.Editor {
	[CustomPropertyDrawer(typeof(InspectorRenameAttribute))]
	public class InspectorRenameDrawer : PropertyDrawer {
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
			// Get the attribute data
			InspectorRenameAttribute renameAttribute = (InspectorRenameAttribute)attribute;

			// Change the label's text to the new name
			label.text = renameAttribute.NewName;

			// Draw the property with the new label
			EditorGUI.PropertyField(position, property, label);
		}
	}
}