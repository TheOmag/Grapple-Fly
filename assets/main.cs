using HarmonyLib;
using UnityEngine;

namespace main
{
    [HarmonyPatch(typeof(Wildflare.Player.PlayerMovement))]
    [HarmonyPatch("Update", MethodType.Normal)]
    public class code
    {
        public static float speed = 8000f;
        public static float mult = 2f;
        private static void Postfix(Wildflare.Player.PlayerMovement __instance)
        {
            if (Input.GetKey(KeyCode.F) && !Input.GetKey(KeyCode.LeftControl))
            {
                __instance.transform.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward * Time.deltaTime * speed;
            }
            if (Input.GetKey(KeyCode.F) && Input.GetKey(KeyCode.LeftControl))
            {
                __instance.transform.GetComponent<Rigidbody>().velocity = Camera.main.transform.forward * Time.deltaTime * (speed * mult);
            }
            config.code.SetSpeed();
        }
    }
}