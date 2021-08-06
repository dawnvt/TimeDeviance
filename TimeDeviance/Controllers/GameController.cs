using SiraUtil;
using UnityEngine;
using Logger = IPA.Logging.Logger;

namespace TimeDeviance.Controllers
{
    public class GameController
    {
        private readonly NoteController _noteController;
        private readonly PlayerTransforms _playerTransforms;
        private readonly Logger _logger;
        
        public GameController(NoteController noteController, PlayerTransforms playerTransforms, Logger logger)
        {
            _noteController = noteController;
            _playerTransforms = playerTransforms;
            _logger = logger;
        }

        private Vector3 notePos;
        private Vector3 playerPos;
        public void PositionVars()
        {
            notePos = _noteController.beatPos;
            playerPos = _playerTransforms.headWorldPos;

            var distance = Vector3.Distance(notePos, playerPos);
            _logger.Debug($"Current bloq to player distance is {distance}");
        }

        public void Calculate()
        {
            
        }
    }
}