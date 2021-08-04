using SiraUtil;
using UnityEngine;

namespace TimeDeviance.Controllers
{
    public class GameController
    {
        private readonly NoteController _noteController;
        private readonly PlayerTransforms _playerTransforms;
        
        public GameController(NoteController noteController, PlayerTransforms playerTransforms)
        {
            _noteController = noteController;
            _playerTransforms = playerTransforms;
        }

        public void DisplayMS()
        {
            Vector3.Distance(_noteController.beatPos, _playerTransforms.headWorldPos);
            if (Vector3 > )
        }
    }
}