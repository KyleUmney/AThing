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
    public int Health { get; set; }

    public Input Input { get; set; }

    public float ShootingTimer = 100f;

    public Bullet Bullet { get; set; }

    public bool CanShoot = true;

    public Player(Texture2D texture)
      : base(texture)
    {
      Type = SpriteType.Player;
    }

    public override void Update(GameTime gameTime)
    {
      var direction = new Vector2((float)Math.Cos(_rotation - MathHelper.ToRadians(+90)), (float)Math.Sin(_rotation - MathHelper.ToRadians(+90)));

      LookAt();

      if (CanShoot == true && ShootingTimer >= 100f)
      {
        Shooting(50f);
        CanShoot = false;
        ShootingTimer = 0f;
      }
      else if (CanShoot == false && ShootingTimer != 100f)
      {
        ShootingTimer++;
        if (ShootingTimer >= 100f)
        {
          CanShoot = true;
        }
      }
    }

    private void LookAt()
    {
      if (Sprites != null && Sprites.Any(c => c is CrazyBug))
      {
        var enemies = Sprites.Where(c => c is CrazyBug).Select(c => (CrazyBug)c).ToList();
        if (enemies.Count > 0)
        {
          var distance = enemies[0].Position - Position;

          _rotation = (float)Math.Atan2(distance.Y, distance.X) + MathHelper.ToRadians(90);
        }
      }
    }

    private void Shooting(float speed)
    {
      var bullet = Bullet.Clone() as Bullet;
      bullet.Position = this.Position;
      bullet.Colour = this.Colour;
      bullet.Layer = 0.1f;
      bullet.LifeSpan = 10f;
      bullet.Velocity = new Vector2((float)Math.Cos(_rotation - MathHelper.ToRadians(+90)), (float)Math.Sin(_rotation - MathHelper.ToRadians(+90))) * speed;
      bullet.Parent = this;

      Children.Add(bullet);
    }
  }
}
