using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AThing.Sprites
{
  public class Sprite : Component, ICloneable
  {
    protected float _rotation;

    public Random _rnd = new Random();

    public List<Vector2> _wayPoints = new List<Vector2>
    {
      new Vector2(1,1),
      new Vector2(100,1),
      new Vector2(200,1),
      new Vector2(300,1),
      new Vector2(400,1),
      new Vector2(500,1),
      new Vector2(600,1),
      new Vector2(700,1),
      new Vector2(800,1),
      new Vector2(900,1),
      new Vector2(1000,1),
      new Vector2(1100,1),
      new Vector2(1279,1),
      new Vector2(1279,100),
      new Vector2(1279,200),
      new Vector2(1279,300),
      new Vector2(1279,400),
      new Vector2(1279,500),
      new Vector2(1279,600),
      new Vector2(1279,700),
      new Vector2(1279,719),
      new Vector2(1279,719),
      new Vector2(1100,719),
      new Vector2(1000,719),
      new Vector2(900,719),
      new Vector2(800,719),
      new Vector2(700,719),
      new Vector2(600,719),
      new Vector2(500,719),
      new Vector2(400,719),
      new Vector2(300,719),
      new Vector2(200,719),
      new Vector2(100,719),
      new Vector2(1,719),
      new Vector2(1,619),
      new Vector2(1,519),
      new Vector2(1,419),
      new Vector2(1,319),
      new Vector2(1,219),
      new Vector2(1,119),
      new Vector2(1,1),
    };
    protected Texture2D _texture;

    public Color Colour { get; set; }

    public float Layer { get; set; }

    public bool IsRemoved { get; set; }

    public bool CanShoot { get; set; }

    public SpriteType Type { get; set; }

    public List<Sprite> Children { get; set; }

    public Vector2 Origin
    {
      get
      {
        return new Vector2(_texture.Width / 2, _texture.Height / 2);
      }
    }

    public Vector2 Position { get; set; }

    public enum SpriteType
    {
      Player,
      Enemy
    }

    public Rectangle Rectangle
    {
      get
      {
        return new Rectangle((int)Position.X - (int)Origin.X, (int)Position.Y - (int)Origin.Y, _texture.Width, _texture.Height);
      }
    }
<<<<<<< HEAD
=======
    public Sprite Parent;

    public List<Sprite> Sprites { get; set; }
>>>>>>> 770bfaa5d5b7e16d87377806f1f3bcc0527b16ca

    public Sprite(Texture2D texture)
    {
      _texture = texture;

      Children = new List<Sprite>();

      Colour = Color.White;
    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Draw(_texture, Position, null, Colour, _rotation, Origin, 1f, SpriteEffects.None, Layer);
    }

    public override void Update(GameTime gameTime)
    {

    }

    public object Clone()
    {
      return this.MemberwiseClone();
    }
  }
}
