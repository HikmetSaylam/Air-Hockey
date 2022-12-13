using System;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    public class Tower : MonoBehaviour
    {
        [Serializable]
        public class GoalEnhancer : UnityEvent { }

        [SerializeField] private GoalEnhancer _goalEnhancer;

        private void OnTriggerEnter2D(Component col)
        {
            if (!col.tag.Equals("Ball")) return;
            _goalEnhancer.Invoke();
            col.gameObject.transform.position=Vector3.zero;
            GameManager.Instance.UpdateScoreTable();
        
        }
    }
}
