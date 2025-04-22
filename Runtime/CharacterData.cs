using Sirenix.OdinInspector;
using UnityEngine;

namespace UnityRPGEditor
{
    [CreateAssetMenu(menuName = "RPG Editor/New Character")]
    public class CharacterData : ScriptableObject
    {
        [field: SerializeField]
        public string Name { get; private set; }
        
        [field: SerializeField, TextArea]
        public string Backstory { get; private set; }

        [field: SerializeField, PreviewField(Height = 100)]   //sprite preview with editor height in px
        public Sprite Portrait { get; private set; }

        [field: SerializeField, InlineEditor] //shows foldout editor for asset
        public ClassData Class {  get; private set; }

        [field: SerializeField, InlineEditor]
        public WeaponData EquippedWeapon { get; private set; }

        [field: SerializeField, InlineEditor]
        public ItemData[] Inventory{ get; private set; }
    }
}
