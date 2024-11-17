using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;


namespace SVLib
{
    public class SVLib : Mod
    {
        /// <summary>
        /// Method to check if player is standing on solid ground or not
        /// </summary>
        /// <param name="player"></param>
        /// <returns>True if is on ground or false if not</returns>
        public static bool IsPlayerOnGround(Player player)
        {
            // Get the tile directly below the player's feet
            int tileX = (int)(player.position.X + player.width / 2) / 16; // Horizontal center of player
            int tileY = (int)(player.position.Y + player.height + 1) / 16; // Bottom edge of player

            // Get the tile at the calculated position
            Tile tile = Main.tile[tileX, tileY];

            // Check if the tile is active and solid (indicates ground)
            return tile != null && tile.HasUnactuatedTile && Main.tileSolid[tile.TileType];
        }
    }
}