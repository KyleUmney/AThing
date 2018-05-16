using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AThing
{
  public class Spawner
  {
    public Vector2[] spawnPoints = new Vector2[]
    {
      new Vector2(0,0),
    };

    private Texture2D _enemy;

    public Spawner(ContentManager _content, Texture2D _enemy)
    {
      _enemy = _content.Load<Texture2D>("Sprites/Enemy");

    }
  }
}
