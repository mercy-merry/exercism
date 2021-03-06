const vowelRegex = RegExp(/(^|\s+)(a|e|i|o|u|yt|xr)(\w+)/g)
const consonantRegex = RegExp(/(^|\s+)(ch|qu|thr|th|sch|yt|\wqu|\w)(\w+)/g)

const vowelReplacement = "$1$2$3ay"
const consonantReplacement = "$1$3$2ay"

export default class PigLatin {
    public static translate(sentence: string) {
        return vowelRegex.test(sentence)
            ? sentence.replace(vowelRegex, vowelReplacement)
            : sentence.replace(consonantRegex, consonantReplacement)
    }
}
