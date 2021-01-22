using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MadLib : MonoBehaviour
{
    // Our story
    // 1. Once upon a time there was a [adjective_1] [noun_1].
    // 2. Every day, the [adjective_1] [noun_1] would [adverb_1] [verb_1] the [place_1] [noun_2],
    // 3. until one day, the [noun_3] [past_tense_verb_1] [adjective_2].
    // 4. Because of this, the [place_2] [noun_3] [past_tense_verb_2] [ing_word_1].
    // 5. And because of that, the [adjective_1] [noun_1] [past_tense_verb_3] [ing_word_2],
    // 6. until finally the [adjective_4] [noun_4] [past_tense_verb_4] the [adjective_1] [noun_1] a [adjective_5] [noun_5].
    // 7. And ever since that day the [place_2] [past_tense_verb_5] the [adjective_1] [noun_1] and the [adjective_4] [noun_4] and the [noun_6] of the [adjective_5] [noun_5].
    // 8. The End.

    List<string> nouns = new List<string> { "monkey", "banana", "cheese", "bunny", "rabbit"};
    List<string> adjectives = new List<string> { "happy", "sad", "royal", "magic", "facetious" };
    List<string> places = new List<string> { "town", "village", "palace", "schoolyard" };
    List<string> verbs = new List<string> { "sweep", "wash", "dance with", "fly over" };
    List<string> pasttenseverbs = new List<string> { "stopped", "began", "started", "continued" };
    List<string> ingwords = new List<string> { "glowing", "shining", "crying", "grinning" };
    List<string> adverbs = new List<string> { "quickly", "quietly", "slowly", "noisily" };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Press ENTER to play.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // story line 1
            string adjective_1 = adjectives[Random.Range(0, adjectives.Count)];
            string noun_1 = nouns[Random.Range(0, nouns.Count)];
            Debug.Log($"Once upon a time there was a {adjective_1} {noun_1}.");

            // story line 2
            string adverb_1 = adverbs[Random.Range(0, adverbs.Count)];
            string verb_1 = verbs[Random.Range(0, verbs.Count)];
            string place_1 = places[Random.Range(0, nouns.Count)];
            string noun_2 = nouns[Random.Range(0, nouns.Count)];
            Debug.Log($"Every day, the {adjective_1} {noun_1} would {adverb_1} {verb_1} the {place_1} {noun_2},");

            // TODO: complete the story lines 3-7

            // story line 8
            Debug.Log("The End.");
        }
    }


}
