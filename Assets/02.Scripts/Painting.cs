using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Painting Data", menuName = "Scriptable Object/Painting Data", order = int.MaxValue)]
public class Painting : ScriptableObject
{
    [SerializeField]
    private string paintingName;
    public string PaintingName { get { return paintingName; } }

    [SerializeField]
    private int paintingID;
    public int PaintingID { get { return paintingID; } }

    [SerializeField]
    private Sprite paintingSprite;
    public Sprite PaintingSprite { get { return paintingSprite; } }

    [SerializeField]
    private string[] paintingAnnounce;
    public string[] PaintingAnnounce { get { return paintingAnnounce; } }

    [SerializeField]
    private AudioClip paintingAudioClip;
    public AudioClip PaintingAudioClip { get { return paintingAudioClip; } }
}
