require_relative 'Boolean/sdk_requirements'
include MyNamespace

describe Bool do
  before(:all) do
    @base_url = ENV['StubServerURI']

    dummyToken = 'dummy12321343423'
	@credentials = MsRest::TokenCredentials.new(dummyToken)

    client = MyNamespace::AutoRestBoolTestService.new(@credentials, @base_url)
    @bool_client = MyNamespace::Bool.new(client)
  end
  def to_bool(str)
    return true if str =~ (/^(true)$/i)
    return false if str =~ (/^(false)$/i)
    raise ArgumentError
  end

  it 'should create test service' do
    expect { MyNamespace::AutoRestBoolTestService.new(@credentials, @base_url) }.not_to raise_error
  end
  it 'should get true' do
    result = @bool_client.get_true().value!
    expect(result.response).to be_an_instance_of(Net::HTTPOK)
    expect(result.body).to eq(true)
  end
  it 'should get false' do
    result = @bool_client.get_false().value!
    expect(result.response).to be_an_instance_of(Net::HTTPOK)
    expect(result.body).to eq(false)
  end
  it 'should put true' do
    result = @bool_client.put_true(true).value!
    expect(result.response).to be_an_instance_of(Net::HTTPOK)
  end
  it 'should put false' do
    result = @bool_client.put_false(false).value!
    expect(result.response).to be_an_instance_of(Net::HTTPOK)
  end
   it 'should get null' do
    result = @bool_client.get_null().value!
	expect(result.response).to be_an_instance_of(Net::HTTPOK)
	expect(result.body).to eq(nil)
  end
   it 'should get invalid' do
    expect { result = @bool_client.get_invalid().value! }.to raise_error(MsRest::DeserializationError)
  end
end