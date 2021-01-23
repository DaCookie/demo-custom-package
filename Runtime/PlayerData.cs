using UnityEngine;

namespace CustomPackage
{

    [CreateAssetMenu(fileName = "NewPlayerData", menuName = "Player Data")]
    public class PlayerData : ScriptableObject
    {

        [SerializeField]
        private string m_PlayerName;
        public string Player => m_PlayerName;

        [SerializeField]
        private int m_Score = 0;
        public int Score => m_Score;

    }

}