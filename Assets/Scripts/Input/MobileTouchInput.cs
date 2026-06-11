using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;

namespace SuperOffRoad.Input
{
    public class MobileTouchInput : MonoBehaviour
    {
        [Header("Touch Sensitivity")]
        [SerializeField] private float dragThreshold = 50f;
        [SerializeField] private float screenDragSensitivity = 1f;

        public delegate void TouchInputDelegate(Vector2 touchPosition);
        public delegate void DragInputDelegate(Vector2 dragDelta);

        public event TouchInputDelegate OnTouchDown;
        public event TouchInputDelegate OnTouchUp;
        public event DragInputDelegate OnDrag;

        private Vector2 touchStartPosition;
        private Vector2 currentTouchPosition;
        private bool isDragging = false;
        private Touch currentTouch;

        private void OnEnable()
        {
            EnhancedTouchSupport.Enable();
        }

        private void OnDisable()
        {
            EnhancedTouchSupport.Disable();
        }

        private void Update()
        {
            HandleTouchInput();
        }

        private void HandleTouchInput()
        {
            if (Touchscreen.current == null)
                return;

            var touches = UnityEngine.InputSystem.EnhancedTouch.Touch.activeTouches;

            if (touches.Count == 0)
            {
                if (isDragging)
                {
                    isDragging = false;
                    OnTouchUp?.Invoke(currentTouchPosition);
                }
                return;
            }

            currentTouch = touches[0];
            currentTouchPosition = currentTouch.screenPosition;

            if (currentTouch.phase == TouchPhase.Began)
            {
                touchStartPosition = currentTouchPosition;
                OnTouchDown?.Invoke(touchStartPosition);
                isDragging = false;
            }
            else if (currentTouch.phase == TouchPhase.Moved)
            {
                Vector2 dragDelta = currentTouchPosition - touchStartPosition;
                
                if (!isDragging && dragDelta.magnitude > dragThreshold)
                {
                    isDragging = true;
                }

                if (isDragging)
                {
                    OnDrag?.Invoke(dragDelta * screenDragSensitivity);
                }
            }
            else if (currentTouch.phase == TouchPhase.Ended || currentTouch.phase == TouchPhase.Canceled)
            {
                isDragging = false;
                OnTouchUp?.Invoke(currentTouchPosition);
            }
        }

        public Vector2 GetCurrentTouchPosition()
        {
            return currentTouchPosition;
        }

        public bool IsTouching()
        {
            return Touchscreen.current != null && Touchscreen.current.press.isPressed;
        }

        public Vector2 GetTouchDelta()
        {
            return currentTouchPosition - touchStartPosition;
        }
    }
}
