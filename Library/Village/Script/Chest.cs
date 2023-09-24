using UnityEngine;
using Cainos.LucidEditor;

namespace Cainos.PixelArtPlatformer_VillageProps
{
    public class Chest : MonoBehaviour
    {
        [FoldoutGroup("Reference")]
        public Animator animator;
        private int isOpen;
        private void OnEnable()
        {
            isOpen = PlayerPrefs.GetInt("ChestOpen", 0);
            IsOpened = (isOpen == 1);
        }

        [FoldoutGroup("Runtime"), ShowInInspector, DisableInEditMode]
        public bool IsOpened
        {
            get { return isOpened; }
            set
            {
                isOpened = value;
                animator.SetBool("IsOpened", isOpened);
                PlayerPrefs.SetInt("ChestOpen", isOpened ? 1 : 0);
            }
        }
        private bool isOpened;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Open();
            }
        }

        [FoldoutGroup("Runtime"),Button("Open"), HorizontalGroup("Runtime/Button")]
        public void Open()
        {
            IsOpened = true;
            
        }

        [FoldoutGroup("Runtime"), Button("Close"), HorizontalGroup("Runtime/Button")]
        public void Close()
        {
            IsOpened = false;
        }

    }
}
