using UnityEngine;
using YG;
public class PopupRewardVideo : MonoBehaviour
{
    [SerializeField] private int _adID;

    private void AddHintReward(int id)
    {
        if (id == _adID)
        {
            GameDefine.hintCount += 1;
            gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        YandexGame.RewardVideoEvent += AddHintReward;
    }

    private void OnDisable()
    {
        YandexGame.RewardVideoEvent -= AddHintReward;
    }
}