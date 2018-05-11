using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AThing.Sprites
{
 public class CrazyBug : Sprite
  {
    private float _speed = 3f;

    private List<Vector2> wayPoints = new List<Vector2>
    {
      new Vector2(0,0),
      new Vector2(500,100),
      new Vector2(500,400),
      new Vector2(100,400),
    };

    private int _wayPointIndex;

    private Vector2 _currentWaypoint;

    public int Health { get; set; }

    public CrazyBug(Texture2D texture)
      : base(texture)
    {
      _wayPointIndex = 0;
    }

    public override void Update(GameTime gameTime)
    {
      if (wayPoints.Count > 0)
        _currentWaypoint = wayPoints[_wayPointIndex];

      MoveToWaypoint(gameTime);

      base.Update(gameTime);
    }

    private void MoveToWaypoint(GameTime gameTime)
    {
      Vector2 currentPosition = Position;

      Vector2 targetPosition = _currentWaypoint;

      Vector2 direction = targetPosition - currentPosition;

      Position += direction / 10;

      if (Vector2.Distance(currentPosition, targetPosition) < 10f)
      {
        _wayPointIndex++;
        if (_wayPointIndex >= wayPoints.Count)
          _wayPointIndex = 0;
      }

      Vector2 dir = targetPosition - Position;
      float angle = (float)Math.Atan2(dir.Y, dir.X);

    }
  }
}
