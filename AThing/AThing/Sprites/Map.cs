using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AThing.Sprites
{
  public class Map : Sprite
  {
    private float _timer;

    public float LifeSpan { get; set; }

    public Vector2 Velocity { get; set; }

    public Map(Texture2D texture)
      : base(texture)
    {
    }

    public override void Update(GameTime gameTime)
    {
      _timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

      if (_timer >= LifeSpan)
        IsRemoved = true;

      Position += Velocity;

      base.Update(gameTime);
    }
  }
}
