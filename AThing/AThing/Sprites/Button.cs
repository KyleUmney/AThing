using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AThing.Sprites
{
  class Button : Component
  {
    private SpriteFont _font;

    private Texture2D _texture;

    public EventHandler click;

    public bool Clicked { get; set; }

    public float Layer { get; set; }

    public Vector2 Origin
    {
      get
      {
        return new Vector2(_texture.Width / 2, _texture.Height / 2);
      }
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {

    }

    public override void Update(GameTime gameTime)
    {

    }
  }
}
