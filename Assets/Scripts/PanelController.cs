using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public GameObject panelWarning; // Panel yang ingin ditutup
    private string panelStatusKey = "panelShown";

    void Start()
    {
        // Cek apakah panel sudah pernah ditampilkan sebelumnya
        if (PlayerPrefs.GetInt(panelStatusKey, 0) == 0)
        {
            // Panel belum ditampilkan sebelumnya, tampilkan panel
            panelWarning.SetActive(true);
        }
        else
        {
            // Panel sudah ditampilkan sebelumnya, nonaktifkan panel
            panelWarning.SetActive(false);
        }
    }

    void OnButtonAgreeClick()
    {
        // Menutup panel ketika tombol "Agree" diklik
        panelWarning.SetActive(false);

        // Menandai bahwa panel sudah ditampilkan sehingga tidak muncul lagi di kunjungan berikutnya
        PlayerPrefs.SetInt(panelStatusKey, 1);
        PlayerPrefs.Save();
    }
}
