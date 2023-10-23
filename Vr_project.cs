using System.Collections;
using System.Collections.Generic; using UnityEngine;
public class Explainer : MonoBehaviour {
public Animator animator;
public AudioSource audioSource; private void Awake()
{
audioSource.Stop(); }
// Start is called before the first frame update void Start()
{
}
// Update is called once per frame void Update()
{
}
void OnTriggerEnter() {
animator.SetBool("Explaining", true);
audioSource.Play(); }
private void OnTriggerExit(Collider other) {
animator.SetBool("Explaining", false);
audioSource.Stop(); }
}