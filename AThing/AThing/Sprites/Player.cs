using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AThing.Models;
using AThing.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AThing.Sprites
{
  public class Player : Sprite
  {
    private float _speed = 10f;

    private CrazyBug _enemy;

    public int Health { get; set; }

    public Input Input { get; set; }

    public Player(Texture2D texture)
      : base(texture)
    {

    }

    public override void Update(GameTime gameTime)
    {
      Vector2 velocity = new Vector2();

      //if (Keyboard.GetState().IsKeyDown(Input.Right))
      //  _rotation += MathHelper.ToRadians(10);

      //if (Keyboard.GetState().IsKeyDown(Input.Left))
      //  _rotation -= MathHelper.ToRadians(10);

      if (Keyboard.GetState().IsKeyDown(Input.Up))
        velocity.Y -= 10;

      if (Keyboard.GetState().IsKeyDown(Input.Down))
        velocity.Y += 10;

      var direction = new Vector2((float)Math.Cos(_rotation - MathHelper.ToRadians(+90)), (float)Math.Sin(_rotation - MathHelper.ToRadians(+90)));



      if (Keyboard.GetState().IsKeyDown(Input.Up))
        Position += direction * _speed;

      if (Keyboard.GetState().IsKeyDown(Input.Down))
        Position -= direction * _speed;

      var distance =  _enemy.Position - Position; //Mouse.GetState().Position.ToVector2()

      _rotation = (float)Math.Atan2(distance.Y, distance.X) + MathHelper.ToRadians(90);
    }
  }
}
