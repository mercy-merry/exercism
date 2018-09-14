import kotlin.coroutines.experimental.buildSequence

object PascalsTriangle {
    fun computeTriangle(rows: Int): List<List<Int>> {
        require(rows >= 0) { "Rows can't be negative!" }
        return (1..rows).map(this::row)
    }

    private fun row(i: Int): List<Int> {
        return buildSequence {
            var column = 1
            yield(column)

            for (j in 1 until i) {
                column = column * (i - j) / j
                yield(column)
            }
        }.toList()
    }
}