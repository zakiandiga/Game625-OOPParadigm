using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Observer
{
    void OnNotify(object obj, NotificationType notif);
}

public enum NotificationType
{
    ScoreZombie,
    PowerupSpeed,
    PowerupStrength,
    EnemyKilled,


}
