using Microsoft.AspNetCore.Mvc;

namespace EstoqueAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstoqueController : ControllerBase
    {
        private static List<Item> listaItems = new List<Item>
        {
            new Item { Id = 1, Nome = "Bicicleta", Preco = 150.00, Estoque = 10 },
            new Item { Id = 2, Nome = "Monitor LG", Preco = 299.99, Estoque = 5 },
            new Item { Id = 3, Nome = "Chinelo", Preco = 65.59, Estoque = 7 },
            new Item { Id = 4, Nome = "Almofada", Preco = 31.25, Estoque = 11 },
            new Item { Id = 5, Nome = "Cortinas", Preco = 120.00, Estoque = 3 }
        };

        [HttpGet]
        public ActionResult<List<Item>> Get() => Ok(listaItems);

        [HttpPost]
        public IActionResult Post([FromBody] Item novoItem)
        {
            novoItem.Id = listaItems.Max(i => i.Id) + 1;
            listaItems.Add(novoItem);
            return CreatedAtAction(nameof(Get), new { id = novoItem.Id }, novoItem);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Item itemNovo)
        {
            var estoqueOriginal = listaItems.FirstOrDefault(p => p.Id == id);
            if (estoqueOriginal == null) return NotFound("Item não encontrado!");

            estoqueOriginal.Nome = itemNovo.Nome;
            estoqueOriginal.Preco = itemNovo.Preco;
            estoqueOriginal.Estoque = itemNovo.Estoque;

            return Ok(estoqueOriginal);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = listaItems.FirstOrDefault(p => p.Id == id);
            if (item == null) return NotFound("Item não encontrado!");

            listaItems.Remove(item);
            return NoContent();
        }
    }
}
