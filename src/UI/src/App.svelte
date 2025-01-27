<script>
  let name = $state("none");
  async function getName(url) {
    console.log("start");
    const responce = await fetch(`${url}/name/`);
    const responceJson = await responce.json();
    console.log("some");
    name = responceJson.name;
  }
</script>

<main>
  <div>
    <p> my name is {name} </p>
    <button onclick={() => getName("http://localhost:5289")}>get name</button>
  </div>

</main>

<style>
</style>
