using Sirenix.OdinInspector;
using UnityEngine;

namespace UnityRPGEditor
{
    [CreateAssetMenu(menuName = "RPG Editor/New Skill")]
    public class SkillData : ScriptableObject
    {
        [field: SerializeField]
        public string Name { get; private set; }

        [field: SerializeField, TextArea]
        public string Description { get; private set; }

        [field: SerializeField, PreviewField(Height = 100)]
        public Sprite Icon { get; private set; }

        [field: SerializeField]
        public float Power { get; private set; } = 5f;

        [field: SerializeField]
        public float Cooldown { get; private set; } = 5f;

        [field: SerializeField]
        public float CastSpeed { get; private set; } = 5f;

        [field: SerializeField]
        public float AfterCastDelay { get; private set; } = 0.05f;

        [field: SerializeField]
        public float ManaCost { get; private set; } = 5f;
    }
}
