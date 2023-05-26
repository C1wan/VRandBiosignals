using UnityEngine;

namespace _3rd_Party_Assets.Gun__Target.Scripts
{
    public class Target : MonoBehaviour
    {
        private MeshRenderer meshRenderer;
        private BoxCollider boxCollider;
        private AudioSource audioSource;
        private ParticleSystem particleSystem;
        private Vector3 randomRotation;
        private bool isDisabled;


        private void Awake()
        {
            meshRenderer = GetComponent<MeshRenderer>();
            boxCollider = GetComponent<BoxCollider>();
            audioSource = GetComponent<AudioSource>();
            audioSource = GetComponent<AudioSource>();
            particleSystem = GetComponentInChildren<ParticleSystem>();
            // hier irgwndwo bioisggnale einbauen das die cubes sich schnerller bewegen 
            // und opacity etc. geändert weredn
            randomRotation = new Vector3(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f),
            Random.Range(0.1f, 1f));

        }

        private void Update() => Rotate();

        // biosignale hier referenzieren
        private void Rotate() => transform.Rotate(randomRotation);


        private void OnCollisionEnter(Collision other)
        {
            if (!isDisabled && other.gameObject.CompareTag("Bullet"))
            {
                Destroy(other.gameObject);
                ToggleTarget();
                TargetDestroyEffect();
                Invoke("ToggleTarget", 3f);
            }
        }
        private void ToggleTarget()
        {
                meshRenderer.enabled = isDisabled;
                boxCollider.enabled = isDisabled;
                // turns isDisabled to the opposite
                isDisabled = !isDisabled;

        }

        private void TargetDestroyEffect()
        {
            var random = Random.Range(0.8f, 1.2f);
            audioSource.pitch = random;

            audioSource.Play();
            particleSystem.Play();

        }

    }
}