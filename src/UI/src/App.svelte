<script>
  let name = $state("none");
  async function getName() {
    console.log("start");
    const responce = await fetch(`/user/1`);
    const responceJson = await responce.json();
    console.log("some");
    name = responceJson.Name;
  }
</script>

<main>
  <div>
    <p> my name is {name} </p>
    <button onclick={() => getName()}>get name</button>
  </div>

</main>

<style>
</style>
